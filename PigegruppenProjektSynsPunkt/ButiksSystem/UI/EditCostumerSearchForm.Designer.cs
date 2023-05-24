namespace ButiksSystem.UI
{
    partial class EditCostumerSearchForm
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
            this.txt_searchCustomerIDOrName = new System.Windows.Forms.TextBox();
            this.dgv_showCustomerInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_showCustomerInfo = new System.Windows.Forms.Button();
            this.txt_changeCustomerCity = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerAddress = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerEmail = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerLastName = new System.Windows.Forms.TextBox();
            this.txt_changeCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txt_showCustomerIDFromSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_saveEditedCustomerToDatabase = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_deleteCustomerInDatabase = new System.Windows.Forms.Button();
            this.btn_OKShowCostumer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast Kunde Nr. / KundeNavn :";
            // 
            // txt_searchCustomerIDOrName
            // 
            this.txt_searchCustomerIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchCustomerIDOrName.Location = new System.Drawing.Point(253, 68);
            this.txt_searchCustomerIDOrName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchCustomerIDOrName.Name = "txt_searchCustomerIDOrName";
            this.txt_searchCustomerIDOrName.Size = new System.Drawing.Size(188, 24);
            this.txt_searchCustomerIDOrName.TabIndex = 1;
            this.txt_searchCustomerIDOrName.Text = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII" +
    "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII";
            this.txt_searchCustomerIDOrName.TextChanged += new System.EventHandler(this.txt_searchCustomerIDOrName_TextChanged);
            // 
            // dgv_showCustomerInfo
            // 
            this.dgv_showCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_showCustomerInfo.Location = new System.Drawing.Point(32, 141);
            this.dgv_showCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_showCustomerInfo.Name = "dgv_showCustomerInfo";
            this.dgv_showCustomerInfo.RowHeadersWidth = 51;
            this.dgv_showCustomerInfo.RowTemplate.Height = 24;
            this.dgv_showCustomerInfo.Size = new System.Drawing.Size(406, 229);
            this.dgv_showCustomerInfo.TabIndex = 2;
            this.dgv_showCustomerInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showCustomerInfo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kunde Nr.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kunde Navn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 275;
            // 
            // btn_showCustomerInfo
            // 
            this.btn_showCustomerInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showCustomerInfo.Location = new System.Drawing.Point(253, 383);
            this.btn_showCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showCustomerInfo.Name = "btn_showCustomerInfo";
            this.btn_showCustomerInfo.Size = new System.Drawing.Size(185, 26);
            this.btn_showCustomerInfo.TabIndex = 3;
            this.btn_showCustomerInfo.Text = "Vis Kundeoplysninger";
            this.btn_showCustomerInfo.UseVisualStyleBackColor = false;
            this.btn_showCustomerInfo.Click += new System.EventHandler(this.btn_showCustomerInfo_Click);
            // 
            // txt_changeCustomerCity
            // 
            this.txt_changeCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerCity.Location = new System.Drawing.Point(604, 342);
            this.txt_changeCustomerCity.Name = "txt_changeCustomerCity";
            this.txt_changeCustomerCity.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerCity.TabIndex = 32;
            // 
            // txt_changeCustomerPostalCode
            // 
            this.txt_changeCustomerPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPostalCode.Location = new System.Drawing.Point(604, 313);
            this.txt_changeCustomerPostalCode.Name = "txt_changeCustomerPostalCode";
            this.txt_changeCustomerPostalCode.Size = new System.Drawing.Size(100, 24);
            this.txt_changeCustomerPostalCode.TabIndex = 31;
            // 
            // txt_changeCustomerAddress
            // 
            this.txt_changeCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerAddress.Location = new System.Drawing.Point(604, 283);
            this.txt_changeCustomerAddress.Name = "txt_changeCustomerAddress";
            this.txt_changeCustomerAddress.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerAddress.TabIndex = 30;
            // 
            // txt_changeCustomerEmail
            // 
            this.txt_changeCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerEmail.Location = new System.Drawing.Point(604, 253);
            this.txt_changeCustomerEmail.Name = "txt_changeCustomerEmail";
            this.txt_changeCustomerEmail.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerEmail.TabIndex = 29;
            // 
            // txt_changeCustomerPhoneNumber
            // 
            this.txt_changeCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPhoneNumber.Location = new System.Drawing.Point(604, 225);
            this.txt_changeCustomerPhoneNumber.Name = "txt_changeCustomerPhoneNumber";
            this.txt_changeCustomerPhoneNumber.Size = new System.Drawing.Size(100, 24);
            this.txt_changeCustomerPhoneNumber.TabIndex = 28;
            // 
            // txt_changeCustomerLastName
            // 
            this.txt_changeCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerLastName.Location = new System.Drawing.Point(604, 195);
            this.txt_changeCustomerLastName.Name = "txt_changeCustomerLastName";
            this.txt_changeCustomerLastName.Size = new System.Drawing.Size(125, 24);
            this.txt_changeCustomerLastName.TabIndex = 27;
            // 
            // txt_changeCustomerFirstName
            // 
            this.txt_changeCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerFirstName.Location = new System.Drawing.Point(604, 165);
            this.txt_changeCustomerFirstName.Name = "txt_changeCustomerFirstName";
            this.txt_changeCustomerFirstName.Size = new System.Drawing.Size(125, 24);
            this.txt_changeCustomerFirstName.TabIndex = 26;
            // 
            // txt_showCustomerIDFromSearch
            // 
            this.txt_showCustomerIDFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showCustomerIDFromSearch.Location = new System.Drawing.Point(604, 136);
            this.txt_showCustomerIDFromSearch.Name = "txt_showCustomerIDFromSearch";
            this.txt_showCustomerIDFromSearch.ReadOnly = true;
            this.txt_showCustomerIDFromSearch.Size = new System.Drawing.Size(100, 24);
            this.txt_showCustomerIDFromSearch.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "By : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Postnummer :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adresse : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tlf.nr. : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Efternavn : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fornavn : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kunde ID : ";
            // 
            // btn_saveEditedCustomerToDatabase
            // 
            this.btn_saveEditedCustomerToDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saveEditedCustomerToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditedCustomerToDatabase.Location = new System.Drawing.Point(654, 383);
            this.btn_saveEditedCustomerToDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveEditedCustomerToDatabase.Name = "btn_saveEditedCustomerToDatabase";
            this.btn_saveEditedCustomerToDatabase.Size = new System.Drawing.Size(119, 26);
            this.btn_saveEditedCustomerToDatabase.TabIndex = 33;
            this.btn_saveEditedCustomerToDatabase.Text = "Gem Kundeoplysninger";
            this.btn_saveEditedCustomerToDatabase.UseVisualStyleBackColor = false;
            this.btn_saveEditedCustomerToDatabase.Click += new System.EventHandler(this.btn_saveEditedCustomerToDatabase_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(505, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kundeoplysninger";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 29);
            this.label11.TabIndex = 35;
            this.label11.Text = "Kundeinformationer";
            // 
            // btn_deleteCustomerInDatabase
            // 
            this.btn_deleteCustomerInDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleteCustomerInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCustomerInDatabase.Location = new System.Drawing.Point(508, 383);
            this.btn_deleteCustomerInDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteCustomerInDatabase.Name = "btn_deleteCustomerInDatabase";
            this.btn_deleteCustomerInDatabase.Size = new System.Drawing.Size(119, 26);
            this.btn_deleteCustomerInDatabase.TabIndex = 36;
            this.btn_deleteCustomerInDatabase.Text = "Slet Kunde";
            this.btn_deleteCustomerInDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteCustomerInDatabase.Click += new System.EventHandler(this.btn_deleteCustomerInDatabase_Click);
            // 
            // btn_OKShowCostumer
            // 
            this.btn_OKShowCostumer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OKShowCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKShowCostumer.Location = new System.Drawing.Point(253, 105);
            this.btn_OKShowCostumer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OKShowCostumer.Name = "btn_OKShowCostumer";
            this.btn_OKShowCostumer.Size = new System.Drawing.Size(185, 26);
            this.btn_OKShowCostumer.TabIndex = 37;
            this.btn_OKShowCostumer.Text = "OK";
            this.btn_OKShowCostumer.UseVisualStyleBackColor = false;
            this.btn_OKShowCostumer.Click += new System.EventHandler(this.btn_OKShowCostumer_Click);
            // 
            // EditCostumerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 423);
            this.Controls.Add(this.btn_OKShowCostumer);
            this.Controls.Add(this.btn_deleteCustomerInDatabase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_saveEditedCustomerToDatabase);
            this.Controls.Add(this.txt_changeCustomerCity);
            this.Controls.Add(this.txt_changeCustomerPostalCode);
            this.Controls.Add(this.txt_changeCustomerAddress);
            this.Controls.Add(this.txt_changeCustomerEmail);
            this.Controls.Add(this.txt_changeCustomerPhoneNumber);
            this.Controls.Add(this.txt_changeCustomerLastName);
            this.Controls.Add(this.txt_changeCustomerFirstName);
            this.Controls.Add(this.txt_showCustomerIDFromSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_showCustomerInfo);
            this.Controls.Add(this.dgv_showCustomerInfo);
            this.Controls.Add(this.txt_searchCustomerIDOrName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditCostumerSearchForm";
            this.Text = "Rediger Kunde";
            this.Load += new System.EventHandler(this.EditCostumerSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchCustomerIDOrName;
        private System.Windows.Forms.DataGridView dgv_showCustomerInfo;
        private System.Windows.Forms.Button btn_showCustomerInfo;
        private System.Windows.Forms.TextBox txt_changeCustomerCity;
        private System.Windows.Forms.TextBox txt_changeCustomerPostalCode;
        private System.Windows.Forms.TextBox txt_changeCustomerAddress;
        private System.Windows.Forms.TextBox txt_changeCustomerEmail;
        private System.Windows.Forms.TextBox txt_changeCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txt_changeCustomerLastName;
        private System.Windows.Forms.TextBox txt_changeCustomerFirstName;
        private System.Windows.Forms.TextBox txt_showCustomerIDFromSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_saveEditedCustomerToDatabase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_deleteCustomerInDatabase;
        private System.Windows.Forms.Button btn_OKShowCostumer;
    }
}