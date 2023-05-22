namespace ButiksSystem.UI
{
    partial class CreateProductForm
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
            this.btn_createProduct = new System.Windows.Forms.Button();
            this.txt_createQuantityInStorage = new System.Windows.Forms.TextBox();
            this.txt_createProductGroupID = new System.Windows.Forms.TextBox();
            this.txt_CreateSalesPricePerItem = new System.Windows.Forms.TextBox();
            this.txt_createProductName = new System.Windows.Forms.TextBox();
            this.txt_createProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createProduct
            // 
            this.btn_createProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_createProduct.Location = new System.Drawing.Point(174, 138);
            this.btn_createProduct.Name = "btn_createProduct";
            this.btn_createProduct.Size = new System.Drawing.Size(80, 23);
            this.btn_createProduct.TabIndex = 33;
            this.btn_createProduct.Text = "Opret Vare";
            this.btn_createProduct.UseVisualStyleBackColor = false;
            // 
            // txt_createQuantityInStorage
            // 
            this.txt_createQuantityInStorage.Location = new System.Drawing.Point(102, 112);
            this.txt_createQuantityInStorage.Name = "txt_createQuantityInStorage";
            this.txt_createQuantityInStorage.Size = new System.Drawing.Size(100, 20);
            this.txt_createQuantityInStorage.TabIndex = 29;
            // 
            // txt_createProductGroupID
            // 
            this.txt_createProductGroupID.Location = new System.Drawing.Point(102, 87);
            this.txt_createProductGroupID.Name = "txt_createProductGroupID";
            this.txt_createProductGroupID.Size = new System.Drawing.Size(100, 20);
            this.txt_createProductGroupID.TabIndex = 28;
            // 
            // txt_CreateSalesPricePerItem
            // 
            this.txt_CreateSalesPricePerItem.Location = new System.Drawing.Point(102, 62);
            this.txt_CreateSalesPricePerItem.Name = "txt_CreateSalesPricePerItem";
            this.txt_CreateSalesPricePerItem.Size = new System.Drawing.Size(100, 20);
            this.txt_CreateSalesPricePerItem.TabIndex = 27;
            // 
            // txt_createProductName
            // 
            this.txt_createProductName.Location = new System.Drawing.Point(102, 36);
            this.txt_createProductName.Name = "txt_createProductName";
            this.txt_createProductName.Size = new System.Drawing.Size(152, 20);
            this.txt_createProductName.TabIndex = 26;
            // 
            // txt_createProductID
            // 
            this.txt_createProductID.Location = new System.Drawing.Point(102, 11);
            this.txt_createProductID.Name = "txt_createProductID";
            this.txt_createProductID.ReadOnly = true;
            this.txt_createProductID.Size = new System.Drawing.Size(152, 20);
            this.txt_createProductID.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lagerbeholdning : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Varegruppe ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Salgspris pr. stk. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Varenavn : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vare ID : ";
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 168);
            this.Controls.Add(this.btn_createProduct);
            this.Controls.Add(this.txt_createQuantityInStorage);
            this.Controls.Add(this.txt_createProductGroupID);
            this.Controls.Add(this.txt_CreateSalesPricePerItem);
            this.Controls.Add(this.txt_createProductName);
            this.Controls.Add(this.txt_createProductID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createProduct;
        private System.Windows.Forms.TextBox txt_createQuantityInStorage;
        private System.Windows.Forms.TextBox txt_createProductGroupID;
        private System.Windows.Forms.TextBox txt_CreateSalesPricePerItem;
        private System.Windows.Forms.TextBox txt_createProductName;
        private System.Windows.Forms.TextBox txt_createProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}