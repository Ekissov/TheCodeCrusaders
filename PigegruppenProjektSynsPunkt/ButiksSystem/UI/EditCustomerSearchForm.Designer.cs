﻿namespace ButiksSystem.UI
{
    partial class EditCustomerSearchForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchCustomerIDOrName = new System.Windows.Forms.TextBox();
            this.dgv_showCustomerInfo = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saanneeha_dk_db_databaseDataSet = new ButiksSystem.Saanneeha_dk_db_databaseDataSet();
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
            this.btn_OKShowCustomer = new System.Windows.Forms.Button();
            this.btn_homePageHelp = new System.Windows.Forms.Button();
            this.customerTableTableAdapter = new ButiksSystem.Saanneeha_dk_db_databaseDataSetTableAdapters.CustomerTableTableAdapter();
            this.saanneeha_dk_db_databaseDataSet2 = new ButiksSystem.Saanneeha_dk_db_databaseDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new ButiksSystem.Saanneeha_dk_db_databaseDataSet2TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast KundeNr / KundeNavn :";
            // 
            // txt_searchCustomerIDOrName
            // 
            this.txt_searchCustomerIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchCustomerIDOrName.Location = new System.Drawing.Point(253, 68);
            this.txt_searchCustomerIDOrName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchCustomerIDOrName.Name = "txt_searchCustomerIDOrName";
            this.txt_searchCustomerIDOrName.Size = new System.Drawing.Size(188, 24);
            this.txt_searchCustomerIDOrName.TabIndex = 1;
            this.txt_searchCustomerIDOrName.TextChanged += new System.EventHandler(this.txt_searchCustomerIDOrName_TextChanged);
            // 
            // dgv_showCustomerInfo
            // 
            this.dgv_showCustomerInfo.AutoGenerateColumns = false;
            this.dgv_showCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dgv_showCustomerInfo.DataSource = this.customerBindingSource;
            this.dgv_showCustomerInfo.Location = new System.Drawing.Point(32, 141);
            this.dgv_showCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_showCustomerInfo.Name = "dgv_showCustomerInfo";
            this.dgv_showCustomerInfo.RowHeadersWidth = 51;
            this.dgv_showCustomerInfo.RowTemplate.Height = 24;
            this.dgv_showCustomerInfo.Size = new System.Drawing.Size(442, 229);
            this.dgv_showCustomerInfo.TabIndex = 2;
            this.dgv_showCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showCustomerInfo_CellClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.saanneeha_dk_db_databaseDataSet;
            // 
            // saanneeha_dk_db_databaseDataSet
            // 
            this.saanneeha_dk_db_databaseDataSet.DataSetName = "Saanneeha_dk_db_databaseDataSet";
            this.saanneeha_dk_db_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txt_changeCustomerCity.Location = new System.Drawing.Point(642, 340);
            this.txt_changeCustomerCity.Name = "txt_changeCustomerCity";
            this.txt_changeCustomerCity.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerCity.TabIndex = 32;
            // 
            // txt_changeCustomerPostalCode
            // 
            this.txt_changeCustomerPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPostalCode.Location = new System.Drawing.Point(642, 311);
            this.txt_changeCustomerPostalCode.Name = "txt_changeCustomerPostalCode";
            this.txt_changeCustomerPostalCode.Size = new System.Drawing.Size(100, 24);
            this.txt_changeCustomerPostalCode.TabIndex = 31;
            // 
            // txt_changeCustomerAddress
            // 
            this.txt_changeCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerAddress.Location = new System.Drawing.Point(642, 281);
            this.txt_changeCustomerAddress.Name = "txt_changeCustomerAddress";
            this.txt_changeCustomerAddress.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerAddress.TabIndex = 30;
            // 
            // txt_changeCustomerEmail
            // 
            this.txt_changeCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerEmail.Location = new System.Drawing.Point(642, 251);
            this.txt_changeCustomerEmail.Name = "txt_changeCustomerEmail";
            this.txt_changeCustomerEmail.Size = new System.Drawing.Size(169, 24);
            this.txt_changeCustomerEmail.TabIndex = 29;
            // 
            // txt_changeCustomerPhoneNumber
            // 
            this.txt_changeCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPhoneNumber.Location = new System.Drawing.Point(642, 223);
            this.txt_changeCustomerPhoneNumber.Name = "txt_changeCustomerPhoneNumber";
            this.txt_changeCustomerPhoneNumber.Size = new System.Drawing.Size(100, 24);
            this.txt_changeCustomerPhoneNumber.TabIndex = 28;
            // 
            // txt_changeCustomerLastName
            // 
            this.txt_changeCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerLastName.Location = new System.Drawing.Point(642, 193);
            this.txt_changeCustomerLastName.Name = "txt_changeCustomerLastName";
            this.txt_changeCustomerLastName.Size = new System.Drawing.Size(125, 24);
            this.txt_changeCustomerLastName.TabIndex = 27;
            // 
            // txt_changeCustomerFirstName
            // 
            this.txt_changeCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerFirstName.Location = new System.Drawing.Point(642, 163);
            this.txt_changeCustomerFirstName.Name = "txt_changeCustomerFirstName";
            this.txt_changeCustomerFirstName.Size = new System.Drawing.Size(125, 24);
            this.txt_changeCustomerFirstName.TabIndex = 26;
            // 
            // txt_showCustomerIDFromSearch
            // 
            this.txt_showCustomerIDFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showCustomerIDFromSearch.Location = new System.Drawing.Point(642, 134);
            this.txt_showCustomerIDFromSearch.Name = "txt_showCustomerIDFromSearch";
            this.txt_showCustomerIDFromSearch.ReadOnly = true;
            this.txt_showCustomerIDFromSearch.Size = new System.Drawing.Size(100, 24);
            this.txt_showCustomerIDFromSearch.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "By : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Postnummer :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adresse : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tlf.nr. : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Efternavn : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fornavn : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kunde ID : ";
            // 
            // btn_saveEditedCustomerToDatabase
            // 
            this.btn_saveEditedCustomerToDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saveEditedCustomerToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditedCustomerToDatabase.Location = new System.Drawing.Point(692, 381);
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
            this.label10.Location = new System.Drawing.Point(543, 65);
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
            this.btn_deleteCustomerInDatabase.Location = new System.Drawing.Point(546, 381);
            this.btn_deleteCustomerInDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteCustomerInDatabase.Name = "btn_deleteCustomerInDatabase";
            this.btn_deleteCustomerInDatabase.Size = new System.Drawing.Size(119, 26);
            this.btn_deleteCustomerInDatabase.TabIndex = 36;
            this.btn_deleteCustomerInDatabase.Text = "Slet Kunde";
            this.btn_deleteCustomerInDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteCustomerInDatabase.Click += new System.EventHandler(this.btn_deleteCustomerInDatabase_Click);
            // 
            // btn_OKShowCustomer
            // 
            this.btn_OKShowCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OKShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKShowCustomer.Location = new System.Drawing.Point(253, 105);
            this.btn_OKShowCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OKShowCustomer.Name = "btn_OKShowCustomer";
            this.btn_OKShowCustomer.Size = new System.Drawing.Size(185, 26);
            this.btn_OKShowCustomer.TabIndex = 37;
            this.btn_OKShowCustomer.Text = "OK";
            this.btn_OKShowCustomer.UseVisualStyleBackColor = false;
            this.btn_OKShowCustomer.Click += new System.EventHandler(this.btn_OKShowCustomer_Click);
            // 
            // btn_homePageHelp
            // 
            this.btn_homePageHelp.BackColor = System.Drawing.Color.Silver;
            this.btn_homePageHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homePageHelp.Location = new System.Drawing.Point(748, 20);
            this.btn_homePageHelp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_homePageHelp.Name = "btn_homePageHelp";
            this.btn_homePageHelp.Size = new System.Drawing.Size(25, 29);
            this.btn_homePageHelp.TabIndex = 38;
            this.btn_homePageHelp.Tag = "";
            this.btn_homePageHelp.Text = "?";
            this.btn_homePageHelp.UseVisualStyleBackColor = false;
            this.btn_homePageHelp.Click += new System.EventHandler(this.btn_homePageHelp_Click);
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // saanneeha_dk_db_databaseDataSet2
            // 
            this.saanneeha_dk_db_databaseDataSet2.DataSetName = "Saanneeha_dk_db_databaseDataSet2";
            this.saanneeha_dk_db_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.saanneeha_dk_db_databaseDataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // EditCustomerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 423);
            this.Controls.Add(this.btn_homePageHelp);
            this.Controls.Add(this.btn_OKShowCustomer);
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
            this.Name = "EditCustomerSearchForm";
            this.Text = "Rediger Kunde";
            this.Load += new System.EventHandler(this.EditCustomerSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_deleteCustomerInDatabase;
        private System.Windows.Forms.Button btn_OKShowCustomer;
        private System.Windows.Forms.Button btn_homePageHelp;
        private Saanneeha_dk_db_databaseDataSet saanneeha_dk_db_databaseDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private Saanneeha_dk_db_databaseDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private Saanneeha_dk_db_databaseDataSet2 saanneeha_dk_db_databaseDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Saanneeha_dk_db_databaseDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}