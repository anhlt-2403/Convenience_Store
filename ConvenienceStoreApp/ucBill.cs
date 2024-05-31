using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStoreApp
{
    public partial class ucBill : Form
    {
        class DataGridCheckoutObject
        {
            public string ProductName { get; set; }
            public double? ProductPrice { get; set; }
            public int? Quantity { get; set; }
            public double? Total { get; set; }
        }

        public TblOrder order { get; set; }
        public List<TblOrderDetail> orderDetails { get; set; }
        public TblStaff loggedStaff { get; set; }
        public String customerName { get; set; }
        public List<TblProduct> products = new List<TblProduct>();

        public ucBill()
        {
            InitializeComponent();
        }

        private double CalculateTotal()
        {
            double total = 0;
            orderDetails.ForEach(od => total += (double)od.TotalPrice);
            return total;
        }

        private void parseAllText()
        {
            lblOrderIdValue.Text = order.OrderId.ToString();
            lblTotalValue.Text = CalculateTotal().ToString();

            lblCustomerName.Text = customerName;
            lblDateValue.Text = order.Date.ToString();
        }

        private void UpdateGridView()
        {
            List<DataGridCheckoutObject> dataObj = new List<DataGridCheckoutObject>();
            orderDetails.ForEach(od =>
            {
                TblProduct prod = products.Single(p => p.ProductId == od.ProductId);
                dataObj.Add(new()
                {
                    ProductName = prod.ProductName,
                    ProductPrice = prod.Price,
                    Quantity = od.Quantity,
                    Total = od.TotalPrice
                });
            });

            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = dataObj;

        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                parseAllText();
                UpdateGridView();
            }
        }
        private void PrintInvoice()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            string invoiceContent = GetInvoiceContent();

            using (var graphics = e.Graphics)
            {
                using (var font = new Font("Arial", 12))
                {
                    float x = e.MarginBounds.Left;
                    float y = e.MarginBounds.Top;
                    graphics.DrawString(invoiceContent, font, Brushes.Black, x, y);
                }
            }
        }

        private string GetInvoiceContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Detail".PadLeft((40 - "Order Detail".Length) / 2 + "Order Detail".Length).ToUpper());
            sb.AppendLine($"Order ID: {order.OrderId}");
            sb.AppendLine($"Customer: {customerName}");
            sb.AppendLine("Items:");

            if (dgvOrderDetails.DataSource is List<DataGridCheckoutObject> dataObj)
            {
                foreach (var item in dataObj)
                {
                    sb.AppendLine($"{item.ProductName,-20}: {item.Quantity,5} x {item.ProductPrice,10} = {item.Total,10}");
                }
                sb.AppendLine($"Total: {lblTotalValue.Text}");
            }
            return sb.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }
    }
}
