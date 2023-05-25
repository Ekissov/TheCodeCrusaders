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
            this.btn_showProductInfo = new System.Windows.Forms.Button();
            this.dgv_showProductInfo = new System.Windows.Forms.DataGridView();
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
            this.btn_OKShowProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showProductInfo
            // 
            this.btn_showProductInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showProductInfo.Location = new System.Drawing.Point(366, 580);
            this.btn_showProductInfo.Name = "btn_showProductInfo";
            this.btn_showProductInfo.Size = new System.Drawing.Size(222, 51);
            this.btn_showProductInfo.TabIndex = 37;
            this.btn_showProductInfo.Text = "Vis Vareoplysninger";
            this.btn_showProductInfo.UseVisualStyleBackColor = false;
            this.btn_showProductInfo.Click += new System.EventHandler(this.btn_showProductInfo_Click);
            // 
            // dgv_showProductInfo
            // 
            this.dgv_showProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showProductInfo.Location = new System.Drawing.Point(21, 268);
            this.dgv_showProductInfo.Name = "dgv_showProductInfo";
            this.dgv_showProductInfo.RowHeadersWidth = 51;
            this.dgv_showProductInfo.RowTemplate.Height = 24;
            this.dgv_showProductInfo.Size = new System.Drawing.Size(567, 298);
            this.dgv_showProductInfo.TabIndex = 36;
            this.dgv_showProductInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showProductInfo_CellContentClick);
            // 
            // txt_searchProductIDOrName
            // 
            this.txt_searchProductIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchProductIDOrName.Location = new System.Drawing.Point(322, 123);
            this.txt_searchProductIDOrName.Name = "txt_searchProductIDOrName";
            this.txt_searchProductIDOrName.Size = new System.Drawing.Size(264, 32);
            this.txt_searchProductIDOrName.TabIndex = 35;
            this.txt_searchProductIDOrName.Text = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII" +
    "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII";
            this.txt_searchProductIDOrName.TextChanged += new System.EventHandler(this.txt_searchProductIDOrName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Indtast Vare Nr. / Vare Navn :";
            // 
            // txt_editQuantityInStorage
            // 
            this.txt_editQuantityInStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editQuantityInStorage.Location = new System.Drawing.Point(816, 409);
            this.txt_editQuantityInStorage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_editQuantityInStorage.Name = "txt_editQuantityInStorage";
            this.txt_editQuantityInStorage.Size = new System.Drawing.Size(148, 32);
            this.txt_editQuantityInStorage.TabIndex = 47;
            // 
            // txt_editProductGroupID
            // 
            this.txt_editProductGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductGroupID.Location = new System.Drawing.Point(816, 352);
            this.txt_editProductGroupID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_editProductGroupID.Name = "txt_editProductGroupID";
            this.txt_editProductGroupID.Size = new System.Drawing.Size(148, 32);
            this.txt_editProductGroupID.TabIndex = 46;
            // 
            // txt_editProductPricePerItem
            // 
            this.txt_editProductPricePerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductPricePerItem.Location = new System.Drawing.Point(816, 297);
            this.txt_editProductPricePerItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_editProductPricePerItem.Name = "txt_editProductPricePerItem";
            this.txt_editProductPricePerItem.Size = new System.Drawing.Size(148, 32);
            this.txt_editProductPricePerItem.TabIndex = 45;
            // 
            // txt_editProductName
            // 
            this.txt_editProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editProductName.Location = new System.Drawing.Point(816, 238);
            this.txt_editProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_editProductName.Name = "txt_editProductName";
            this.txt_editProductName.Size = new System.Drawing.Size(226, 32);
            this.txt_editProductName.TabIndex = 44;
            // 
            // txt_showProductIDFromSearch
            // 
            this.txt_showProductIDFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showProductIDFromSearch.Location = new System.Drawing.Point(816, 183);
            this.txt_showProductIDFromSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_showProductIDFromSearch.Name = "txt_showProductIDFromSearch";
            this.txt_showProductIDFromSearch.ReadOnly = true;
            this.txt_showProductIDFromSearch.Size = new System.Drawing.Size(226, 32);
            this.txt_showProductIDFromSearch.TabIndex = 43;
            this.txt_showProductIDFromSearch.Text = "ooooooooooooooooooo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lagerbeholdning : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Varegruppe ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Salgspris pr. stk. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Varenavn : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "Vare ID : ";
            // 
            // btn_saveEditedProductToDatabase
            // 
            this.btn_saveEditedProductToDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saveEditedProductToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditedProductToDatabase.Location = new System.Drawing.Point(822, 498);
            this.btn_saveEditedProductToDatabase.Name = "btn_saveEditedProductToDatabase";
            this.btn_saveEditedProductToDatabase.Size = new System.Drawing.Size(222, 49);
            this.btn_saveEditedProductToDatabase.TabIndex = 48;
            this.btn_saveEditedProductToDatabase.Text = "Gem Vareoplysninger";
            this.btn_saveEditedProductToDatabase.UseVisualStyleBackColor = false;
            this.btn_saveEditedProductToDatabase.Click += new System.EventHandler(this.btn_saveEditedProductToDatabase_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Vareoplysinger";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 40);
            this.label8.TabIndex = 50;
            this.label8.Text = "Vareinformationer";
            // 
            // btn_deleteProductInDatabase
            // 
            this.btn_deleteProductInDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleteProductInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProductInDatabase.Location = new System.Drawing.Point(612, 498);
            this.btn_deleteProductInDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deleteProductInDatabase.Name = "btn_deleteProductInDatabase";
            this.btn_deleteProductInDatabase.Size = new System.Drawing.Size(178, 48);
            this.btn_deleteProductInDatabase.TabIndex = 51;
            this.btn_deleteProductInDatabase.Text = "Slet Vare";
            this.btn_deleteProductInDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteProductInDatabase.Click += new System.EventHandler(this.btn_deleteProductInDatabase_Click);
            // 
            // btn_OKShowProducts
            // 
            this.btn_OKShowProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OKShowProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKShowProducts.Location = new System.Drawing.Point(366, 183);
            this.btn_OKShowProducts.Name = "btn_OKShowProducts";
            this.btn_OKShowProducts.Size = new System.Drawing.Size(222, 51);
            this.btn_OKShowProducts.TabIndex = 52;
            this.btn_OKShowProducts.Text = "OK";
            this.btn_OKShowProducts.UseVisualStyleBackColor = false;
            this.btn_OKShowProducts.Click += new System.EventHandler(this.btn_OKShowProducts_Click);
            // 
            // EditProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 714);
            this.Controls.Add(this.btn_OKShowProducts);
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
            this.Controls.Add(this.btn_showProductInfo);
            this.Controls.Add(this.dgv_showProductInfo);
            this.Controls.Add(this.txt_searchProductIDOrName);
            this.Controls.Add(this.label1);
            this.Name = "EditProductSearchForm";
            this.Text = "Rediger Produkt";
            this.Load += new System.EventHandler(this.EditProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showProductInfo;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_deleteProductInDatabase;
        private System.Windows.Forms.Button btn_OKShowProducts;
    }
}