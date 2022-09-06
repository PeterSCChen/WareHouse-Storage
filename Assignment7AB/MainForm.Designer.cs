
namespace Assignment7AB
{
    partial class MainForm
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
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.labelTotalYTDSalesResult = new System.Windows.Forms.Label();
            this.labelCreditHoldCountResult = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditRecord.Location = new System.Drawing.Point(763, 480);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRecord.TabIndex = 5;
            this.buttonEditRecord.Text = "Edit Record";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.AutoSize = true;
            this.labelTotalYTDSales.Location = new System.Drawing.Point(22, 21);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(88, 13);
            this.labelTotalYTDSales.TabIndex = 1;
            this.labelTotalYTDSales.Text = "Total YTD Sales:";
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Location = new System.Drawing.Point(22, 52);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(89, 13);
            this.labelCreditHoldCount.TabIndex = 3;
            this.labelCreditHoldCount.Text = "Total Credit Hold:";
            // 
            // labelTotalYTDSalesResult
            // 
            this.labelTotalYTDSalesResult.AutoSize = true;
            this.labelTotalYTDSalesResult.Location = new System.Drawing.Point(116, 21);
            this.labelTotalYTDSalesResult.Name = "labelTotalYTDSalesResult";
            this.labelTotalYTDSalesResult.Size = new System.Drawing.Size(94, 13);
            this.labelTotalYTDSalesResult.TabIndex = 1;
            this.labelTotalYTDSalesResult.Text = "<Total YTDSales>";
            // 
            // labelCreditHoldCountResult
            // 
            this.labelCreditHoldCountResult.AutoSize = true;
            this.labelCreditHoldCountResult.Location = new System.Drawing.Point(116, 52);
            this.labelCreditHoldCountResult.Name = "labelCreditHoldCountResult";
            this.labelCreditHoldCountResult.Size = new System.Drawing.Size(98, 13);
            this.labelCreditHoldCountResult.TabIndex = 3;
            this.labelCreditHoldCountResult.Text = "<Total Credit Hold>";
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(25, 86);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(813, 388);
            this.dataGridViewClients.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonEditRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 515);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.labelCreditHoldCountResult);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.labelTotalYTDSalesResult);
            this.Controls.Add(this.labelTotalYTDSales);
            this.Controls.Add(this.buttonEditRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "COMP 2614 Assignment 7";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.Label labelTotalYTDSalesResult;
        private System.Windows.Forms.Label labelCreditHoldCountResult;
        private System.Windows.Forms.DataGridView dataGridViewClients;
    }
}