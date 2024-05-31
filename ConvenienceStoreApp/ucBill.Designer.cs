
namespace ConvenienceStoreApp
{
    partial class ucBill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            lblOrderIdName = new System.Windows.Forms.Label();
            lblOrderIdValue = new System.Windows.Forms.Label();
            dgvOrderDetails = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            lblTotalValue = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblCustomerName = new System.Windows.Forms.Label();
            lblDateValue = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 54);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // lblOrderIdName
            // 
            lblOrderIdName.AutoSize = true;
            lblOrderIdName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOrderIdName.Location = new System.Drawing.Point(14, 61);
            lblOrderIdName.Name = "lblOrderIdName";
            lblOrderIdName.Size = new System.Drawing.Size(96, 25);
            lblOrderIdName.TabIndex = 1;
            lblOrderIdName.Text = "Order Id : ";
            // 
            // lblOrderIdValue
            // 
            lblOrderIdValue.AutoSize = true;
            lblOrderIdValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOrderIdValue.Location = new System.Drawing.Point(93, 64);
            lblOrderIdValue.Name = "lblOrderIdValue";
            lblOrderIdValue.Size = new System.Drawing.Size(108, 23);
            lblOrderIdValue.TabIndex = 2;
            lblOrderIdValue.Text = "orderIdValue";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AllowUserToResizeColumns = false;
            dgvOrderDetails.AllowUserToResizeRows = false;
            dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dgvOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            dgvOrderDetails.Location = new System.Drawing.Point(14, 156);
            dgvOrderDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderDetails.MultiSelect = false;
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 25;
            dgvOrderDetails.Size = new System.Drawing.Size(511, 400);
            dgvOrderDetails.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(455, 569);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 37);
            label2.TabIndex = 4;
            label2.Text = "Total";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalValue.Location = new System.Drawing.Point(14, 604);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new System.Drawing.Size(511, 44);
            lblTotalValue.TabIndex = 5;
            lblTotalValue.Text = "totalValue";
            lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 641);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(148, 25);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 668);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 25);
            label5.TabIndex = 7;
            label5.Text = "Date";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCustomerName.Location = new System.Drawing.Point(153, 644);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new System.Drawing.Size(127, 23);
            lblCustomerName.TabIndex = 8;
            lblCustomerName.Text = "customerName";
            // 
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateValue.Location = new System.Drawing.Point(153, 671);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new System.Drawing.Size(88, 23);
            lblDateValue.TabIndex = 9;
            lblDateValue.Text = "DateValue";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel1.Location = new System.Drawing.Point(14, 564);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(506, 1);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 25);
            label3.TabIndex = 11;
            label3.Text = "Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(126, 116);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(264, 116);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 25);
            label7.TabIndex = 13;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(387, 116);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 25);
            label8.TabIndex = 14;
            label8.Text = "Total";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel2.Location = new System.Drawing.Point(14, 147);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(506, 1);
            panel2.TabIndex = 11;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnPrint.Location = new System.Drawing.Point(411, 661);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(115, 42);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // ucBill
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(538, 707);
            Controls.Add(btnPrint);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblDateValue);
            Controls.Add(lblCustomerName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTotalValue);
            Controls.Add(label2);
            Controls.Add(dgvOrderDetails);
            Controls.Add(lblOrderIdValue);
            Controls.Add(lblOrderIdName);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ucBill";
            Load += ucBill_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderIdName;
        private System.Windows.Forms.Label lblOrderIdValue;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
    }
}
