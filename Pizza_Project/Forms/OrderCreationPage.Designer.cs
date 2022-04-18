namespace Pizza_Project.Forms
{
    partial class OrderCreationPage
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
            this.MenuText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FoodTextLabel = new System.Windows.Forms.Label();
            this.ExtrasTextLabel = new System.Windows.Forms.Label();
            this.DrinkTextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CartTextLabel = new System.Windows.Forms.Label();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuText
            // 
            this.MenuText.AutoSize = true;
            this.MenuText.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuText.ForeColor = System.Drawing.Color.White;
            this.MenuText.Location = new System.Drawing.Point(38, 11);
            this.MenuText.Name = "MenuText";
            this.MenuText.Size = new System.Drawing.Size(108, 45);
            this.MenuText.TabIndex = 0;
            this.MenuText.Text = "Menu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ExtrasTextLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrinkTextLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FoodTextLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FoodTextLabel
            // 
            this.FoodTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoodTextLabel.AutoSize = true;
            this.FoodTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodTextLabel.ForeColor = System.Drawing.Color.White;
            this.FoodTextLabel.Location = new System.Drawing.Point(62, 11);
            this.FoodTextLabel.Name = "FoodTextLabel";
            this.FoodTextLabel.Size = new System.Drawing.Size(59, 28);
            this.FoodTextLabel.TabIndex = 2;
            this.FoodTextLabel.Text = "Food";
            // 
            // ExtrasTextLabel
            // 
            this.ExtrasTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExtrasTextLabel.AutoSize = true;
            this.ExtrasTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtrasTextLabel.ForeColor = System.Drawing.Color.White;
            this.ExtrasTextLabel.Location = new System.Drawing.Point(428, 11);
            this.ExtrasTextLabel.Name = "ExtrasTextLabel";
            this.ExtrasTextLabel.Size = new System.Drawing.Size(59, 28);
            this.ExtrasTextLabel.TabIndex = 3;
            this.ExtrasTextLabel.Text = "Food";
            // 
            // DrinkTextLabel
            // 
            this.DrinkTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrinkTextLabel.AutoSize = true;
            this.DrinkTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrinkTextLabel.ForeColor = System.Drawing.Color.White;
            this.DrinkTextLabel.Location = new System.Drawing.Point(244, 11);
            this.DrinkTextLabel.Name = "DrinkTextLabel";
            this.DrinkTextLabel.Size = new System.Drawing.Size(61, 28);
            this.DrinkTextLabel.TabIndex = 4;
            this.DrinkTextLabel.Text = "Drink";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CartPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CheckoutButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CartTextLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(580, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.09907F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.90093F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 409);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CartTextLabel
            // 
            this.CartTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CartTextLabel.AutoSize = true;
            this.CartTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CartTextLabel.ForeColor = System.Drawing.Color.White;
            this.CartTextLabel.Location = new System.Drawing.Point(78, 14);
            this.CartTextLabel.Name = "CartTextLabel";
            this.CartTextLabel.Size = new System.Drawing.Size(51, 28);
            this.CartTextLabel.TabIndex = 3;
            this.CartTextLabel.Text = "Cart";
            this.CartTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.BackColor = System.Drawing.Color.Orange;
            this.CheckoutButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.Location = new System.Drawing.Point(50, 360);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(108, 38);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            // 
            // CartPanel
            // 
            this.CartPanel.Location = new System.Drawing.Point(3, 59);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(202, 288);
            this.CartPanel.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.Color.Orange;
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(468, 19);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 38);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 311);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuText);
            this.Name = "OrderCreationPage";
            this.Text = "OrderCreationPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ExtrasTextLabel;
        private System.Windows.Forms.Label DrinkTextLabel;
        private System.Windows.Forms.Label FoodTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CartTextLabel;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}