
namespace Pizza_Project.Forms
{
    partial class BeverageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.qtyNumericCounter = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.unsweetTeaCheckbox = new System.Windows.Forms.CheckBox();
            this.cokeCheckbox = new System.Windows.Forms.CheckBox();
            this.spriteCheckbox = new System.Windows.Forms.CheckBox();
            this.pepsiCheckbox = new System.Windows.Forms.CheckBox();
            this.sweetTeaCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.smallCheckbox = new System.Windows.Forms.CheckBox();
            this.mediumCheckbox = new System.Windows.Forms.CheckBox();
            this.largeCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericCounter)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.qtyNumericCounter, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addToCart, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qtyNumericCounter
            // 
            this.qtyNumericCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.qtyNumericCounter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtyNumericCounter.Location = new System.Drawing.Point(531, 14);
            this.qtyNumericCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyNumericCounter.Name = "qtyNumericCounter";
            this.qtyNumericCounter.Size = new System.Drawing.Size(57, 27);
            this.qtyNumericCounter.TabIndex = 3;
            this.qtyNumericCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyNumericCounter.ValueChanged += new System.EventHandler(this.qtyNumericCounter_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(489, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Qty:";
            // 
            // addToCart
            // 
            this.addToCart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addToCart.BackColor = System.Drawing.Color.Orange;
            this.addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addToCart.ForeColor = System.Drawing.Color.White;
            this.addToCart.Location = new System.Drawing.Point(595, 10);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(71, 34);
            this.addToCart.TabIndex = 2;
            this.addToCart.Text = "Add";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Beverage";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15015F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84985F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.36937F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.63063F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(669, 187);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.unsweetTeaCheckbox, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.cokeCheckbox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.spriteCheckbox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pepsiCheckbox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.sweetTeaCheckbox, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(338, 39);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(328, 145);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // unsweetTeaCheckbox
            // 
            this.unsweetTeaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unsweetTeaCheckbox.AutoSize = true;
            this.unsweetTeaCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unsweetTeaCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unsweetTeaCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unsweetTeaCheckbox.ForeColor = System.Drawing.Color.White;
            this.unsweetTeaCheckbox.Location = new System.Drawing.Point(108, 117);
            this.unsweetTeaCheckbox.Name = "unsweetTeaCheckbox";
            this.unsweetTeaCheckbox.Size = new System.Drawing.Size(112, 23);
            this.unsweetTeaCheckbox.TabIndex = 6;
            this.unsweetTeaCheckbox.Text = "Unsweet Tea";
            this.unsweetTeaCheckbox.UseVisualStyleBackColor = true;
            this.unsweetTeaCheckbox.CheckedChanged += new System.EventHandler(this.unsweetTeaCheckbox_CheckedChanged);
            // 
            // cokeCheckbox
            // 
            this.cokeCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cokeCheckbox.AutoSize = true;
            this.cokeCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cokeCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cokeCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cokeCheckbox.ForeColor = System.Drawing.Color.White;
            this.cokeCheckbox.Location = new System.Drawing.Point(117, 3);
            this.cokeCheckbox.Name = "cokeCheckbox";
            this.cokeCheckbox.Size = new System.Drawing.Size(93, 21);
            this.cokeCheckbox.TabIndex = 2;
            this.cokeCheckbox.Text = "Coca Cola";
            this.cokeCheckbox.UseVisualStyleBackColor = true;
            this.cokeCheckbox.CheckedChanged += new System.EventHandler(this.cokeCheckbox_CheckedChanged);
            // 
            // spriteCheckbox
            // 
            this.spriteCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spriteCheckbox.AutoSize = true;
            this.spriteCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spriteCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spriteCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spriteCheckbox.ForeColor = System.Drawing.Color.White;
            this.spriteCheckbox.Location = new System.Drawing.Point(131, 30);
            this.spriteCheckbox.Name = "spriteCheckbox";
            this.spriteCheckbox.Size = new System.Drawing.Size(65, 21);
            this.spriteCheckbox.TabIndex = 3;
            this.spriteCheckbox.Text = "Sprite";
            this.spriteCheckbox.UseVisualStyleBackColor = true;
            this.spriteCheckbox.CheckedChanged += new System.EventHandler(this.spriteCheckbox_CheckedChanged);
            // 
            // pepsiCheckbox
            // 
            this.pepsiCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pepsiCheckbox.AutoSize = true;
            this.pepsiCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pepsiCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pepsiCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pepsiCheckbox.ForeColor = System.Drawing.Color.White;
            this.pepsiCheckbox.Location = new System.Drawing.Point(132, 58);
            this.pepsiCheckbox.Name = "pepsiCheckbox";
            this.pepsiCheckbox.Size = new System.Drawing.Size(63, 23);
            this.pepsiCheckbox.TabIndex = 4;
            this.pepsiCheckbox.Text = "Pepsi";
            this.pepsiCheckbox.UseVisualStyleBackColor = true;
            this.pepsiCheckbox.CheckedChanged += new System.EventHandler(this.pepsiCheckbox_CheckedChanged);
            // 
            // sweetTeaCheckbox
            // 
            this.sweetTeaCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sweetTeaCheckbox.AutoSize = true;
            this.sweetTeaCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sweetTeaCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sweetTeaCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sweetTeaCheckbox.ForeColor = System.Drawing.Color.White;
            this.sweetTeaCheckbox.Location = new System.Drawing.Point(117, 88);
            this.sweetTeaCheckbox.Name = "sweetTeaCheckbox";
            this.sweetTeaCheckbox.Size = new System.Drawing.Size(94, 21);
            this.sweetTeaCheckbox.TabIndex = 5;
            this.sweetTeaCheckbox.Text = "Sweet Tea";
            this.sweetTeaCheckbox.UseVisualStyleBackColor = true;
            this.sweetTeaCheckbox.CheckedChanged += new System.EventHandler(this.sweetTeaCheckbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beverage Size";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(450, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beverage";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.smallCheckbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mediumCheckbox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.largeCheckbox, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(329, 145);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // smallCheckbox
            // 
            this.smallCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallCheckbox.AutoSize = true;
            this.smallCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.smallCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smallCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallCheckbox.ForeColor = System.Drawing.Color.White;
            this.smallCheckbox.Location = new System.Drawing.Point(109, 3);
            this.smallCheckbox.Name = "smallCheckbox";
            this.smallCheckbox.Size = new System.Drawing.Size(111, 21);
            this.smallCheckbox.TabIndex = 1;
            this.smallCheckbox.Text = "Small +$1.00";
            this.smallCheckbox.UseVisualStyleBackColor = true;
            this.smallCheckbox.CheckedChanged += new System.EventHandler(this.smallCheckbox_CheckedChanged);
            // 
            // mediumCheckbox
            // 
            this.mediumCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mediumCheckbox.AutoSize = true;
            this.mediumCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mediumCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mediumCheckbox.ForeColor = System.Drawing.Color.White;
            this.mediumCheckbox.Location = new System.Drawing.Point(100, 30);
            this.mediumCheckbox.Name = "mediumCheckbox";
            this.mediumCheckbox.Size = new System.Drawing.Size(129, 19);
            this.mediumCheckbox.TabIndex = 2;
            this.mediumCheckbox.Text = "Medium +$2.50";
            this.mediumCheckbox.UseVisualStyleBackColor = true;
            this.mediumCheckbox.CheckedChanged += new System.EventHandler(this.mediumCheckbox_CheckedChanged);
            // 
            // largeCheckbox
            // 
            this.largeCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeCheckbox.AutoSize = true;
            this.largeCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.largeCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.largeCheckbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.largeCheckbox.ForeColor = System.Drawing.Color.White;
            this.largeCheckbox.Location = new System.Drawing.Point(108, 56);
            this.largeCheckbox.Name = "largeCheckbox";
            this.largeCheckbox.Size = new System.Drawing.Size(112, 23);
            this.largeCheckbox.TabIndex = 3;
            this.largeCheckbox.Text = "Large +$2.75";
            this.largeCheckbox.UseVisualStyleBackColor = true;
            this.largeCheckbox.CheckedChanged += new System.EventHandler(this.largeCheckbox_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.16817F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.83183F));
            this.tableLayoutPanel5.Controls.Add(this.errorLabel, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 67);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(666, 41);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(560, 11);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 3;
            // 
            // BeverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(687, 298);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BeverageForm";
            this.Text = "Beverage Select";
            this.Load += new System.EventHandler(this.BeverageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericCounter)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown qtyNumericCounter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox unsweetTeaCheckbox;
        private System.Windows.Forms.CheckBox cokeCheckbox;
        private System.Windows.Forms.CheckBox spriteCheckbox;
        private System.Windows.Forms.CheckBox pepsiCheckbox;
        private System.Windows.Forms.CheckBox sweetTeaCheckbox;
        private System.Windows.Forms.CheckBox smallCheckbox;
        private System.Windows.Forms.CheckBox mediumCheckbox;
        private System.Windows.Forms.CheckBox largeCheckbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label errorLabel;
    }
}