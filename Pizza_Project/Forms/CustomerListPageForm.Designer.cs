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
            this.CustomerListDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomerListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerControllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerListPanel
            // 
            this.CustomerListPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerListPanel.AutoScroll = true;
            this.CustomerListPanel.Controls.Add(this.CustomerListDataGrid);
            this.CustomerListPanel.Location = new System.Drawing.Point(261, 12);
            this.CustomerListPanel.Name = "CustomerListPanel";
            this.CustomerListPanel.Size = new System.Drawing.Size(321, 426);
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
            // CustomerListDataGrid
            // 
            this.CustomerListDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListDataGrid.Location = new System.Drawing.Point(3, 27);
            this.CustomerListDataGrid.Name = "CustomerListDataGrid";
            this.CustomerListDataGrid.RowHeadersWidth = 51;
            this.CustomerListDataGrid.RowTemplate.Height = 29;
            this.CustomerListDataGrid.Size = new System.Drawing.Size(300, 188);
            this.CustomerListDataGrid.TabIndex = 0;
            this.CustomerListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerListDataGrid_CellContentClick);
            // 
            // CustomerListPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerListBackButton);
            this.Controls.Add(this.CustomerListPanel);
            this.Name = "CustomerListPageForm";
            this.Text = "CustomerListPageForm";
            this.Load += new System.EventHandler(this.CustomerListPageForm_Load);
            this.CustomerListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerControllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CustomerListPanel;
        private System.Windows.Forms.Button CustomerListBackButton;
        private System.Windows.Forms.BindingSource customerControllerBindingSource;
        private System.Windows.Forms.DataGridView CustomerListDataGrid;
    }
}