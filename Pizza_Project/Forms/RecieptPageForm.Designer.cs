namespace Pizza_Project.Forms
{
    partial class RecieptPageForm
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
            System.Windows.Forms.Label OrderNumberTextLabel;
            this.LayoutPanelReceiptPage = new System.Windows.Forms.TableLayoutPanel();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.FinishButton = new System.Windows.Forms.Button();
            OrderNumberTextLabel = new System.Windows.Forms.Label();
            this.LayoutPanelReceiptPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanelReceiptPage
            // 
            this.LayoutPanelReceiptPage.ColumnCount = 1;
            this.LayoutPanelReceiptPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanelReceiptPage.Controls.Add(OrderNumberTextLabel, 0, 0);
            this.LayoutPanelReceiptPage.Controls.Add(this.OrderPanel, 0, 1);
            this.LayoutPanelReceiptPage.Location = new System.Drawing.Point(275, 7);
            this.LayoutPanelReceiptPage.Name = "LayoutPanelReceiptPage";
            this.LayoutPanelReceiptPage.RowCount = 3;
            this.LayoutPanelReceiptPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.LayoutPanelReceiptPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.7653F));
            this.LayoutPanelReceiptPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0102F));
            this.LayoutPanelReceiptPage.Size = new System.Drawing.Size(250, 392);
            this.LayoutPanelReceiptPage.TabIndex = 5;
            // 
            // OrderNumberTextLabel
            // 
            OrderNumberTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            OrderNumberTextLabel.AutoSize = true;
            OrderNumberTextLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            OrderNumberTextLabel.ForeColor = System.Drawing.Color.White;
            OrderNumberTextLabel.Location = new System.Drawing.Point(3, 8);
            OrderNumberTextLabel.Name = "OrderNumberTextLabel";
            OrderNumberTextLabel.Size = new System.Drawing.Size(87, 28);
            OrderNumberTextLabel.TabIndex = 1;
            OrderNumberTextLabel.Tag = "";
            OrderNumberTextLabel.Text = "Order # ";
            // 
            // OrderPanel
            // 
            this.OrderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderPanel.AutoScroll = true;
            this.OrderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrderPanel.Location = new System.Drawing.Point(3, 47);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(244, 291);
            this.OrderPanel.TabIndex = 0;
            // 
            // FinishButton
            // 
            this.FinishButton.AutoSize = true;
            this.FinishButton.BackColor = System.Drawing.Color.Orange;
            this.FinishButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishButton.ForeColor = System.Drawing.Color.White;
            this.FinishButton.Location = new System.Drawing.Point(275, 405);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(250, 38);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            // 
            // RecieptPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LayoutPanelReceiptPage);
            this.Controls.Add(this.FinishButton);
            this.Name = "RecieptPageForm";
            this.Text = "RecieptPageForm";
            this.LayoutPanelReceiptPage.ResumeLayout(false);
            this.LayoutPanelReceiptPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanelReceiptPage;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Button FinishButton;
    }
}