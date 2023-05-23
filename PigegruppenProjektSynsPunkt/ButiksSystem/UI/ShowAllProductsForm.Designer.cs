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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alle Varerne:";
            // 
            // dgv_showProductInfo
            // 
            this.dgv_showProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_showProductInfo.Location = new System.Drawing.Point(83, 112);
            this.dgv_showProductInfo.Name = "dgv_showProductInfo";
            this.dgv_showProductInfo.RowHeadersWidth = 51;
            this.dgv_showProductInfo.RowTemplate.Height = 24;
            this.dgv_showProductInfo.Size = new System.Drawing.Size(824, 396);
            this.dgv_showProductInfo.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vare Nr.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vare Navn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 50);
            this.button1.TabIndex = 38;
            this.button1.Text = "Print Alle Varer til txtfil.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowAllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_showProductInfo);
            this.Controls.Add(this.label1);
            this.Name = "ShowAllProductsForm";
            this.Text = "ShowAllProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_showProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}