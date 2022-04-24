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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buildPizzaButton = new System.Windows.Forms.Button();
            this.buildPizzaImg = new System.Windows.Forms.PictureBox();
            this.beverageButton = new System.Windows.Forms.Button();
            this.beverageImage = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.CartTextLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildPizzaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageImage)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuText
            // 
            this.MenuText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MenuText.AutoSize = true;
            this.MenuText.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuText.ForeColor = System.Drawing.Color.White;
            this.MenuText.Location = new System.Drawing.Point(3, 19);
            this.MenuText.Name = "MenuText";
            this.MenuText.Size = new System.Drawing.Size(90, 37);
            this.MenuText.TabIndex = 0;
            this.MenuText.Text = "Menu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.buildPizzaButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buildPizzaImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.beverageButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MenuText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.beverageImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buildPizzaButton
            // 
            this.buildPizzaButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buildPizzaButton.BackColor = System.Drawing.Color.Orange;
            this.buildPizzaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildPizzaButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buildPizzaButton.ForeColor = System.Drawing.Color.White;
            this.buildPizzaButton.Location = new System.Drawing.Point(43, 217);
            this.buildPizzaButton.Name = "buildPizzaButton";
            this.buildPizzaButton.Size = new System.Drawing.Size(126, 30);
            this.buildPizzaButton.TabIndex = 5;
            this.buildPizzaButton.Text = "Build A Pizza";
            this.buildPizzaButton.UseVisualStyleBackColor = false;
            this.buildPizzaButton.Click += new System.EventHandler(this.buildPizzaButton_Click);
            // 
            // buildPizzaImg
            // 
            this.buildPizzaImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buildPizzaImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildPizzaImg.Location = new System.Drawing.Point(38, 78);
            this.buildPizzaImg.Name = "buildPizzaImg";
            this.buildPizzaImg.Size = new System.Drawing.Size(136, 133);
            this.buildPizzaImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buildPizzaImg.TabIndex = 2;
            this.buildPizzaImg.TabStop = false;
            this.buildPizzaImg.Click += new System.EventHandler(this.buildPizzaImg_Click);
            // 
            // beverageButton
            // 
            this.beverageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beverageButton.BackColor = System.Drawing.Color.Orange;
            this.beverageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beverageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beverageButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beverageButton.ForeColor = System.Drawing.Color.White;
            this.beverageButton.Location = new System.Drawing.Point(256, 217);
            this.beverageButton.Name = "beverageButton";
            this.beverageButton.Size = new System.Drawing.Size(126, 30);
            this.beverageButton.TabIndex = 3;
            this.beverageButton.Text = "Add A Beverage";
            this.beverageButton.UseVisualStyleBackColor = false;
            this.beverageButton.Click += new System.EventHandler(this.beverageButton_Click);
            // 
            // beverageImage
            // 
            this.beverageImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beverageImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beverageImage.Location = new System.Drawing.Point(251, 78);
            this.beverageImage.Name = "beverageImage";
            this.beverageImage.Size = new System.Drawing.Size(136, 133);
            this.beverageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beverageImage.TabIndex = 4;
            this.beverageImage.TabStop = false;
            this.beverageImage.Click += new System.EventHandler(this.beverageImage_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.Color.Orange;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(341, 21);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 33);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CheckoutButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CartTextLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(442, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.09907F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.90093F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 307);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.BackColor = System.Drawing.Color.Orange;
            this.CheckoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.Location = new System.Drawing.Point(77, 267);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(94, 33);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // CartTextLabel
            // 
            this.CartTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CartTextLabel.AutoSize = true;
            this.CartTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CartTextLabel.ForeColor = System.Drawing.Color.White;
            this.CartTextLabel.Location = new System.Drawing.Point(103, 10);
            this.CartTextLabel.Name = "CartTextLabel";
            this.CartTextLabel.Size = new System.Drawing.Size(42, 23);
            this.CartTextLabel.TabIndex = 3;
            this.CartTextLabel.Text = "Cart";
            this.CartTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(4, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 211);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderCreationPage";
            this.Text = "Take Order";
            this.Load += new System.EventHandler(this.OrderCreationPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildPizzaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageImage)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CartTextLabel;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox buildPizzaImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button beverageButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buildPizzaButton;
        private System.Windows.Forms.PictureBox beverageImage;
    }
}