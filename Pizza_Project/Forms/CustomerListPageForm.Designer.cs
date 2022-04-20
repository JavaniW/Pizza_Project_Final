namespace Pizza_Project.Forms
{
    partial class CustomerListPageForm
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
            this.components = new System.ComponentModel.Container();
            this.CustomerListPanel = new System.Windows.Forms.Panel();
            this.CustomerListBackButton = new System.Windows.Forms.Button();
            this.customerControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerInfoButton = new System.Windows.Forms.Button();
            this.CustomerNumber = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerControllerBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerListPanel
            // 
            this.CustomerListPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerListPanel.AutoScroll = true;
            this.CustomerListPanel.Location = new System.Drawing.Point(193, 12);
            this.CustomerListPanel.Name = "CustomerListPanel";
            this.CustomerListPanel.Size = new System.Drawing.Size(422, 426);
            this.CustomerListPanel.TabIndex = 0;
            // 
            // CustomerListBackButton
            // 
            this.CustomerListBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerListBackButton.AutoSize = true;
            this.CustomerListBackButton.BackColor = System.Drawing.Color.Orange;
            this.CustomerListBackButton.ForeColor = System.Drawing.Color.White;
            this.CustomerListBackButton.Location = new System.Drawing.Point(12, 12);
            this.CustomerListBackButton.Name = "CustomerListBackButton";
            this.CustomerListBackButton.Size = new System.Drawing.Size(97, 35);
            this.CustomerListBackButton.TabIndex = 1;
            this.CustomerListBackButton.Text = "Back";
            this.CustomerListBackButton.UseVisualStyleBackColor = false;
            this.CustomerListBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerControllerBindingSource
            // 
            this.customerControllerBindingSource.DataSource = typeof(Pizza_Project.database.controllers.data_controllers.person_controllers.CustomerController);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerInfoButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerNumber, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(193, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 71);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CustomerInfoButton
            // 
            this.CustomerInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerInfoButton.AutoSize = true;
            this.CustomerInfoButton.BackColor = System.Drawing.Color.Orange;
            this.CustomerInfoButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.CustomerInfoButton.Location = new System.Drawing.Point(304, 16);
            this.CustomerInfoButton.Name = "CustomerInfoButton";
            this.CustomerInfoButton.Size = new System.Drawing.Size(94, 38);
            this.CustomerInfoButton.TabIndex = 3;
            this.CustomerInfoButton.Text = "Info";
            this.CustomerInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CustomerInfoButton.UseVisualStyleBackColor = false;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNumber.AutoSize = true;
            this.CustomerNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerNumber.ForeColor = System.Drawing.Color.White;
            this.CustomerNumber.Location = new System.Drawing.Point(166, 21);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(88, 28);
            this.CustomerNumber.TabIndex = 3;
            this.CustomerNumber.Text = "Number";
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerName.ForeColor = System.Drawing.Color.White;
            this.CustomerName.Location = new System.Drawing.Point(36, 21);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(67, 28);
            this.CustomerName.TabIndex = 4;
            this.CustomerName.Text = "Name";
            // 
            // CustomerListPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CustomerListBackButton);
            this.Controls.Add(this.CustomerListPanel);
            this.Name = "CustomerListPageForm";
            this.Text = "CustomerListPageForm";
            this.Load += new System.EventHandler(this.CustomerListPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerControllerBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CustomerListPanel;
        private System.Windows.Forms.Button CustomerListBackButton;
        private System.Windows.Forms.BindingSource customerControllerBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Button CustomerInfoButton;
        private System.Windows.Forms.Label CustomerNumber;
    }
}