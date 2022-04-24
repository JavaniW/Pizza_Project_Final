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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustomerInfoButton = new System.Windows.Forms.Button();
            this.CustomerNumber = new System.Windows.Forms.Label();
            this.CustomerListBackButton = new System.Windows.Forms.Button();
            this.CustomerListDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // CustomerListBackButton
            // 
            this.CustomerListBackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerListBackButton.AutoSize = true;
            this.CustomerListBackButton.BackColor = System.Drawing.Color.Orange;
            this.CustomerListBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerListBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerListBackButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerListBackButton.ForeColor = System.Drawing.Color.White;
            this.CustomerListBackButton.Location = new System.Drawing.Point(3, 6);
            this.CustomerListBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerListBackButton.Name = "CustomerListBackButton";
            this.CustomerListBackButton.Size = new System.Drawing.Size(96, 34);
            this.CustomerListBackButton.TabIndex = 1;
            this.CustomerListBackButton.Text = "Back";
            this.CustomerListBackButton.UseVisualStyleBackColor = false;
            this.CustomerListBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerListDataGrid
            // 
            this.CustomerListDataGrid.AllowUserToAddRows = false;
            this.CustomerListDataGrid.AllowUserToDeleteRows = false;
            this.CustomerListDataGrid.AllowUserToResizeColumns = false;
            this.CustomerListDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerListDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomerListDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerListDataGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.CustomerListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerListDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerListDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerListDataGrid.EnableHeadersVisualStyles = false;
            this.CustomerListDataGrid.GridColor = System.Drawing.Color.White;
            this.CustomerListDataGrid.Location = new System.Drawing.Point(158, 55);
            this.CustomerListDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerListDataGrid.MinimumSize = new System.Drawing.Size(394, 274);
            this.CustomerListDataGrid.MultiSelect = false;
            this.CustomerListDataGrid.Name = "CustomerListDataGrid";
            this.CustomerListDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerListDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerListDataGrid.RowHeadersVisible = false;
            this.CustomerListDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerListDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerListDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerListDataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.CustomerListDataGrid.RowTemplate.Height = 29;
            this.CustomerListDataGrid.RowTemplate.ReadOnly = true;
            this.CustomerListDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CustomerListDataGrid.Size = new System.Drawing.Size(394, 274);
            this.CustomerListDataGrid.TabIndex = 0;
            this.CustomerListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerListDataGrid_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer List";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.70842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.29158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerListBackButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(479, 5);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(196, 36);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "You are not authorized to view customer information.";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorLabel.Visible = false;
            // 
            // CustomerListPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(702, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CustomerListDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(718, 383);
            this.Name = "CustomerListPageForm";
            this.Text = "CustomerListPageForm";
            this.Load += new System.EventHandler(this.CustomerListPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CustomerListBackButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Button CustomerInfoButton;
        private System.Windows.Forms.Label CustomerNumber;
        private System.Windows.Forms.DataGridView CustomerListDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label errorLabel;
    }
}