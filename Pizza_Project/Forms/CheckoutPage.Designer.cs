namespace Pizza_Project.Forms
{
    partial class CheckoutPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderTotalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PaymentMethodDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OrderTotalLabel
            // 
            this.OrderTotalLabel.AutoSize = true;
            this.OrderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTotalLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderTotalLabel.ForeColor = System.Drawing.Color.White;
            this.OrderTotalLabel.Location = new System.Drawing.Point(21, 23);
            this.OrderTotalLabel.Name = "OrderTotalLabel";
            this.OrderTotalLabel.Size = new System.Drawing.Size(124, 58);
            this.OrderTotalLabel.TabIndex = 0;
            this.OrderTotalLabel.Text = "Order Total:\r\n$ {amount}";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(187, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 358);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PaymentMethodDropdown
            // 
            this.PaymentMethodDropdown.FormattingEnabled = true;
            this.PaymentMethodDropdown.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Check"});
            this.PaymentMethodDropdown.Location = new System.Drawing.Point(619, 23);
            this.PaymentMethodDropdown.Name = "PaymentMethodDropdown";
            this.PaymentMethodDropdown.Size = new System.Drawing.Size(159, 28);
            this.PaymentMethodDropdown.TabIndex = 2;
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PaymentMethodDropdown);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OrderTotalLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "CheckoutPage";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderTotalLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox PaymentMethodDropdown;
    }
}