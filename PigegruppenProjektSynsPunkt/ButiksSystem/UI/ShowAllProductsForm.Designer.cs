namespace ButiksSystem.UI
{
    partial class ShowAllProductsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_showProductInfo = new System.Windows.Forms.DataGridView();
            this.btn_printAllProductsToTxtfile = new System.Windows.Forms.Button();
            this.btn_homePageHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alle Varerne:";
            // 
            // dgv_showProductInfo
            // 
            this.dgv_showProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showProductInfo.Location = new System.Drawing.Point(55, 73);
            this.dgv_showProductInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_showProductInfo.Name = "dgv_showProductInfo";
            this.dgv_showProductInfo.RowHeadersWidth = 51;
            this.dgv_showProductInfo.RowTemplate.Height = 24;
            this.dgv_showProductInfo.Size = new System.Drawing.Size(549, 257);
            this.dgv_showProductInfo.TabIndex = 37;
            // 
            // btn_printAllProductsToTxtfile
            // 
            this.btn_printAllProductsToTxtfile.Location = new System.Drawing.Point(475, 340);
            this.btn_printAllProductsToTxtfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_printAllProductsToTxtfile.Name = "btn_printAllProductsToTxtfile";
            this.btn_printAllProductsToTxtfile.Size = new System.Drawing.Size(129, 32);
            this.btn_printAllProductsToTxtfile.TabIndex = 38;
            this.btn_printAllProductsToTxtfile.Text = "Print Alle Varer til txtfil.";
            this.btn_printAllProductsToTxtfile.UseVisualStyleBackColor = true;
            this.btn_printAllProductsToTxtfile.Click += new System.EventHandler(this.btn_printAllProductsToTxtfile_Click);
            // 
            // btn_homePageHelp
            // 
            this.btn_homePageHelp.BackColor = System.Drawing.Color.Silver;
            this.btn_homePageHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homePageHelp.Location = new System.Drawing.Point(579, 37);
            this.btn_homePageHelp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_homePageHelp.Name = "btn_homePageHelp";
            this.btn_homePageHelp.Size = new System.Drawing.Size(25, 29);
            this.btn_homePageHelp.TabIndex = 55;
            this.btn_homePageHelp.Tag = "";
            this.btn_homePageHelp.Text = "?";
            this.btn_homePageHelp.UseVisualStyleBackColor = false;
            this.btn_homePageHelp.Click += new System.EventHandler(this.btn_homePageHelp_Click);
            // 
            // ShowAllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 380);
            this.Controls.Add(this.btn_homePageHelp);
            this.Controls.Add(this.btn_printAllProductsToTxtfile);
            this.Controls.Add(this.dgv_showProductInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowAllProductsForm";
            this.Text = "ShowAllProductsForm";
            this.Load += new System.EventHandler(this.ShowAllProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_showProductInfo;
        private System.Windows.Forms.Button btn_printAllProductsToTxtfile;
        private System.Windows.Forms.Button btn_homePageHelp;
    }
}