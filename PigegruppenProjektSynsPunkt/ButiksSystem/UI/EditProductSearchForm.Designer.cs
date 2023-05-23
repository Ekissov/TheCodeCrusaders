namespace ButiksSystem.UI
{
    partial class EditProductSearchForm
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
            this.btn_showProductInfoInDatagrid = new System.Windows.Forms.Button();
            this.dgv_showProductInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_searchProductIDOrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_editQuantityInStorage = new System.Windows.Forms.TextBox();
            this.txt_editProductGroupID = new System.Windows.Forms.TextBox();
            this.txt_editProductPricePerItem = new System.Windows.Forms.TextBox();
            this.txt_editProductName = new System.Windows.Forms.TextBox();
            this.txt_showProductIDFromSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_saveEditedProductToDatabase = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_deleteProductInDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showProductInfoInDatagrid
            // 
            this.btn_showProductInfoInDatagrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showProductInfoInDatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showProductInfoInDatagrid.Location = new System.Drawing.Point(244, 322);
            this.btn_showProductInfoInDatagrid.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showProductInfoInDatagrid.Name = "btn_showProductInfoInDatagrid";
            this.btn_showProductInfoInDatagrid.Size = new System.Drawing.Size(148, 33);
            this.btn_showProductInfoInDatagrid.TabIndex = 37;
            this.btn_showProductInfoInDatagrid.Text = "Vis Vareoplysninger";
            this.btn_showProductInfoInDatagrid.UseVisualStyleBackColor = false;
            // 
            // dgv_showProductInfo
            // 
            this.dgv_showProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_showProductInfo.Location = new System.Drawing.Point(14, 119);
            this.dgv_showProductInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_showProductInfo.Name = "dgv_showProductInfo";
            this.dgv_showProductInfo.RowHeadersWidth = 51;
            this.dgv_showProductInfo.RowTemplate.Height = 24;
            this.dgv_showProductInfo.Size = new System.Drawing.Size(378, 194);
            this.dgv_showProductInfo.TabIndex = 36;
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
            // txt_searchProductIDOrName
            // 
            this.txt_searchProductIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProductIDOrName.Location = new System.Drawing.Point(215, 80);
            this.txt_searchProductIDOrName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchProductIDOrName.Name = "txt_searchProductIDOrName";
            this.txt_searchProductIDOrName.Size = new System.Drawing.Size(177, 24);
            this.txt_searchProductIDOrName.TabIndex = 35;
            this.txt_searchProductIDOrName.Text = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII" +
    "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Indtast Vare Nr. / Vare Navn :";
            // 
            // txt_editQuantityInStorage
            // 
            this.txt_editQuantityInStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editQuantityInStorage.Location = new System.Drawing.Point(544, 266);
            this.txt_editQuantityInStorage.Name = "txt_editQuantityInStorage";
            this.txt_editQuantityInStorage.Size = new System.Drawing.Size(100, 24);
            this.txt_editQuantityInStorage.TabIndex = 47;
            // 
            // txt_editProductGroupID
            // 
            this.txt_editProductGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductGroupID.Location = new System.Drawing.Point(544, 229);
            this.txt_editProductGroupID.Name = "txt_editProductGroupID";
            this.txt_editProductGroupID.Size = new System.Drawing.Size(100, 24);
            this.txt_editProductGroupID.TabIndex = 46;
            // 
            // txt_editProductPricePerItem
            // 
            this.txt_editProductPricePerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductPricePerItem.Location = new System.Drawing.Point(544, 193);
            this.txt_editProductPricePerItem.Name = "txt_editProductPricePerItem";
            this.txt_editProductPricePerItem.Size = new System.Drawing.Size(100, 24);
            this.txt_editProductPricePerItem.TabIndex = 45;
            // 
            // txt_editProductName
            // 
            this.txt_editProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductName.Location = new System.Drawing.Point(544, 155);
            this.txt_editProductName.Name = "txt_editProductName";
            this.txt_editProductName.Size = new System.Drawing.Size(152, 24);
            this.txt_editProductName.TabIndex = 44;
            // 
            // txt_showProductIDFromSearch
            // 
            this.txt_showProductIDFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showProductIDFromSearch.Location = new System.Drawing.Point(544, 119);
            this.txt_showProductIDFromSearch.Name = "txt_showProductIDFromSearch";
            this.txt_showProductIDFromSearch.ReadOnly = true;
            this.txt_showProductIDFromSearch.Size = new System.Drawing.Size(152, 24);
            this.txt_showProductIDFromSearch.TabIndex = 43;
            this.txt_showProductIDFromSearch.Text = "ooooooooooooooooooo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lagerbeholdning : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Varegruppe ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Salgspris pr. stk. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Varenavn : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Vare ID : ";
            // 
            // btn_saveEditedProductToDatabase
            // 
            this.btn_saveEditedProductToDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saveEditedProductToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditedProductToDatabase.Location = new System.Drawing.Point(548, 324);
            this.btn_saveEditedProductToDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveEditedProductToDatabase.Name = "btn_saveEditedProductToDatabase";
            this.btn_saveEditedProductToDatabase.Size = new System.Drawing.Size(148, 32);
            this.btn_saveEditedProductToDatabase.TabIndex = 48;
            this.btn_saveEditedProductToDatabase.Text = "Gem Vareoplysninger";
            this.btn_saveEditedProductToDatabase.UseVisualStyleBackColor = false;
            this.btn_saveEditedProductToDatabase.Click += new System.EventHandler(this.btn_saveEditedProductToDatabase_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vareoplysinger";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 29);
            this.label8.TabIndex = 50;
            this.label8.Text = "Vareinformationer";
            // 
            // btn_deleteProductInDatabase
            // 
            this.btn_deleteProductInDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleteProductInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProductInDatabase.Location = new System.Drawing.Point(408, 324);
            this.btn_deleteProductInDatabase.Name = "btn_deleteProductInDatabase";
            this.btn_deleteProductInDatabase.Size = new System.Drawing.Size(119, 31);
            this.btn_deleteProductInDatabase.TabIndex = 51;
            this.btn_deleteProductInDatabase.Text = "Slet Vare";
            this.btn_deleteProductInDatabase.UseVisualStyleBackColor = false;
            // 
            // EditProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 361);
            this.Controls.Add(this.btn_deleteProductInDatabase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_saveEditedProductToDatabase);
            this.Controls.Add(this.txt_editQuantityInStorage);
            this.Controls.Add(this.txt_editProductGroupID);
            this.Controls.Add(this.txt_editProductPricePerItem);
            this.Controls.Add(this.txt_editProductName);
            this.Controls.Add(this.txt_showProductIDFromSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_showProductInfoInDatagrid);
            this.Controls.Add(this.dgv_showProductInfo);
            this.Controls.Add(this.txt_searchProductIDOrName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditProductSearchForm";
            this.Text = "Rediger Produkt";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showProductInfoInDatagrid;
        private System.Windows.Forms.DataGridView dgv_showProductInfo;
        private System.Windows.Forms.TextBox txt_searchProductIDOrName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_editQuantityInStorage;
        private System.Windows.Forms.TextBox txt_editProductGroupID;
        private System.Windows.Forms.TextBox txt_editProductPricePerItem;
        private System.Windows.Forms.TextBox txt_editProductName;
        private System.Windows.Forms.TextBox txt_showProductIDFromSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_saveEditedProductToDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_deleteProductInDatabase;
    }
}