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
            this.btn_homePageHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createProduct
            // 
            this.btn_createProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_createProduct.Location = new System.Drawing.Point(232, 218);
            this.btn_createProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_createProduct.Name = "btn_createProduct";
            this.btn_createProduct.Size = new System.Drawing.Size(107, 28);
            this.btn_createProduct.TabIndex = 33;
            this.btn_createProduct.Text = "Opret Vare";
            this.btn_createProduct.UseVisualStyleBackColor = false;
            this.btn_createProduct.Click += new System.EventHandler(this.btn_createProduct_Click);
            // 
            // txt_createQuantityInStorage
            // 
            this.txt_createQuantityInStorage.Location = new System.Drawing.Point(136, 186);
            this.txt_createQuantityInStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_createQuantityInStorage.Name = "txt_createQuantityInStorage";
            this.txt_createQuantityInStorage.Size = new System.Drawing.Size(132, 22);
            this.txt_createQuantityInStorage.TabIndex = 29;
            // 
            // txt_createProductGroupID
            // 
            this.txt_createProductGroupID.Location = new System.Drawing.Point(136, 155);
            this.txt_createProductGroupID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_createProductGroupID.Name = "txt_createProductGroupID";
            this.txt_createProductGroupID.Size = new System.Drawing.Size(132, 22);
            this.txt_createProductGroupID.TabIndex = 28;
            // 
            // txt_CreateSalesPricePerItem
            // 
            this.txt_CreateSalesPricePerItem.Location = new System.Drawing.Point(136, 124);
            this.txt_CreateSalesPricePerItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CreateSalesPricePerItem.Name = "txt_CreateSalesPricePerItem";
            this.txt_CreateSalesPricePerItem.Size = new System.Drawing.Size(132, 22);
            this.txt_CreateSalesPricePerItem.TabIndex = 27;
            // 
            // txt_createProductName
            // 
            this.txt_createProductName.Location = new System.Drawing.Point(136, 92);
            this.txt_createProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_createProductName.Name = "txt_createProductName";
            this.txt_createProductName.Size = new System.Drawing.Size(201, 22);
            this.txt_createProductName.TabIndex = 26;
            // 
            // txt_createProductID
            // 
            this.txt_createProductID.Location = new System.Drawing.Point(136, 62);
            this.txt_createProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_createProductID.Name = "txt_createProductID";
            this.txt_createProductID.ReadOnly = true;
            this.txt_createProductID.Size = new System.Drawing.Size(201, 22);
            this.txt_createProductID.TabIndex = 25;
            this.txt_createProductID.Text = "Udfyldes Automatisk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lagerbeholdning : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Varegruppe ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Salgspris pr. stk. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Varenavn : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vare ID : ";
            // 
            // btn_homePageHelp
            // 
            this.btn_homePageHelp.BackColor = System.Drawing.Color.Silver;
            this.btn_homePageHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homePageHelp.Location = new System.Drawing.Point(363, 12);
            this.btn_homePageHelp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_homePageHelp.Name = "btn_homePageHelp";
            this.btn_homePageHelp.Size = new System.Drawing.Size(33, 36);
            this.btn_homePageHelp.TabIndex = 34;
            this.btn_homePageHelp.Tag = "";
            this.btn_homePageHelp.Text = "?";
            this.btn_homePageHelp.UseVisualStyleBackColor = false;
            this.btn_homePageHelp.Click += new System.EventHandler(this.btn_homePageHelp_Click);
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 284);
            this.Controls.Add(this.btn_homePageHelp);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateProductForm";
            this.Text = "Opret Vare";
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
        private System.Windows.Forms.Button btn_homePageHelp;
    }
}