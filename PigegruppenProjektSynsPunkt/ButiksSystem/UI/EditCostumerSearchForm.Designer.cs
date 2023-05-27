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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchCustomerIDOrName = new System.Windows.Forms.TextBox();
            this.dgv_showCustomerInfo = new System.Windows.Forms.DataGridView();
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
            this.btn_OKShowCostumer = new System.Windows.Forms.Button();
            this.btn_homePageHelp = new System.Windows.Forms.Button();
            this.customerTableTableAdapter = new ButiksSystem.Saanneeha_dk_db_databaseDataSetTableAdapters.CustomerTableTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast KundeNavn :";
            // 
            // txt_searchCustomerIDOrName
            // 
            this.txt_searchCustomerIDOrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchCustomerIDOrName.Location = new System.Drawing.Point(337, 84);
            this.txt_searchCustomerIDOrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchCustomerIDOrName.Name = "txt_searchCustomerIDOrName";
            this.txt_searchCustomerIDOrName.Size = new System.Drawing.Size(249, 28);
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
            this.dgv_showCustomerInfo.DataSource = this.customerTableBindingSource;
            this.dgv_showCustomerInfo.Location = new System.Drawing.Point(43, 174);
            this.dgv_showCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_showCustomerInfo.Name = "dgv_showCustomerInfo";
            this.dgv_showCustomerInfo.RowHeadersWidth = 51;
            this.dgv_showCustomerInfo.RowTemplate.Height = 24;
            this.dgv_showCustomerInfo.Size = new System.Drawing.Size(589, 282);
            this.dgv_showCustomerInfo.TabIndex = 2;
            this.dgv_showCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showCustomerInfo_CellClick);
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
            this.btn_showCustomerInfo.Location = new System.Drawing.Point(337, 471);
            this.btn_showCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showCustomerInfo.Name = "btn_showCustomerInfo";
            this.btn_showCustomerInfo.Size = new System.Drawing.Size(247, 32);
            this.btn_showCustomerInfo.TabIndex = 3;
            this.btn_showCustomerInfo.Text = "Vis Kundeoplysninger";
            this.btn_showCustomerInfo.UseVisualStyleBackColor = false;
            this.btn_showCustomerInfo.Click += new System.EventHandler(this.btn_showCustomerInfo_Click);
            // 
            // txt_changeCustomerCity
            // 
            this.txt_changeCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerCity.Location = new System.Drawing.Point(856, 419);
            this.txt_changeCustomerCity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerCity.Name = "txt_changeCustomerCity";
            this.txt_changeCustomerCity.Size = new System.Drawing.Size(224, 28);
            this.txt_changeCustomerCity.TabIndex = 32;
            // 
            // txt_changeCustomerPostalCode
            // 
            this.txt_changeCustomerPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPostalCode.Location = new System.Drawing.Point(856, 383);
            this.txt_changeCustomerPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerPostalCode.Name = "txt_changeCustomerPostalCode";
            this.txt_changeCustomerPostalCode.Size = new System.Drawing.Size(132, 28);
            this.txt_changeCustomerPostalCode.TabIndex = 31;
            // 
            // txt_changeCustomerAddress
            // 
            this.txt_changeCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerAddress.Location = new System.Drawing.Point(856, 346);
            this.txt_changeCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerAddress.Name = "txt_changeCustomerAddress";
            this.txt_changeCustomerAddress.Size = new System.Drawing.Size(224, 28);
            this.txt_changeCustomerAddress.TabIndex = 30;
            // 
            // txt_changeCustomerEmail
            // 
            this.txt_changeCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerEmail.Location = new System.Drawing.Point(856, 309);
            this.txt_changeCustomerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerEmail.Name = "txt_changeCustomerEmail";
            this.txt_changeCustomerEmail.Size = new System.Drawing.Size(224, 28);
            this.txt_changeCustomerEmail.TabIndex = 29;
            // 
            // txt_changeCustomerPhoneNumber
            // 
            this.txt_changeCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerPhoneNumber.Location = new System.Drawing.Point(856, 275);
            this.txt_changeCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerPhoneNumber.Name = "txt_changeCustomerPhoneNumber";
            this.txt_changeCustomerPhoneNumber.Size = new System.Drawing.Size(132, 28);
            this.txt_changeCustomerPhoneNumber.TabIndex = 28;
            // 
            // txt_changeCustomerLastName
            // 
            this.txt_changeCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerLastName.Location = new System.Drawing.Point(856, 238);
            this.txt_changeCustomerLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerLastName.Name = "txt_changeCustomerLastName";
            this.txt_changeCustomerLastName.Size = new System.Drawing.Size(165, 28);
            this.txt_changeCustomerLastName.TabIndex = 27;
            // 
            // txt_changeCustomerFirstName
            // 
            this.txt_changeCustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changeCustomerFirstName.Location = new System.Drawing.Point(856, 201);
            this.txt_changeCustomerFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_changeCustomerFirstName.Name = "txt_changeCustomerFirstName";
            this.txt_changeCustomerFirstName.Size = new System.Drawing.Size(165, 28);
            this.txt_changeCustomerFirstName.TabIndex = 26;
            // 
            // txt_showCustomerIDFromSearch
            // 
            this.txt_showCustomerIDFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showCustomerIDFromSearch.Location = new System.Drawing.Point(856, 165);
            this.txt_showCustomerIDFromSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_showCustomerIDFromSearch.Name = "txt_showCustomerIDFromSearch";
            this.txt_showCustomerIDFromSearch.ReadOnly = true;
            this.txt_showCustomerIDFromSearch.Size = new System.Drawing.Size(132, 28);
            this.txt_showCustomerIDFromSearch.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(724, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "By : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Postnummer :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adresse : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tlf.nr. : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Efternavn : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fornavn : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kunde ID : ";
            // 
            // btn_saveEditedCustomerToDatabase
            // 
            this.btn_saveEditedCustomerToDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saveEditedCustomerToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditedCustomerToDatabase.Location = new System.Drawing.Point(923, 469);
            this.btn_saveEditedCustomerToDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveEditedCustomerToDatabase.Name = "btn_saveEditedCustomerToDatabase";
            this.btn_saveEditedCustomerToDatabase.Size = new System.Drawing.Size(159, 32);
            this.btn_saveEditedCustomerToDatabase.TabIndex = 33;
            this.btn_saveEditedCustomerToDatabase.Text = "Gem Kundeoplysninger";
            this.btn_saveEditedCustomerToDatabase.UseVisualStyleBackColor = false;
            this.btn_saveEditedCustomerToDatabase.Click += new System.EventHandler(this.btn_saveEditedCustomerToDatabase_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 22);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kundeoplysninger";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 36);
            this.label11.TabIndex = 35;
            this.label11.Text = "Kundeinformationer";
            // 
            // btn_deleteCustomerInDatabase
            // 
            this.btn_deleteCustomerInDatabase.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_deleteCustomerInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCustomerInDatabase.Location = new System.Drawing.Point(728, 469);
            this.btn_deleteCustomerInDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteCustomerInDatabase.Name = "btn_deleteCustomerInDatabase";
            this.btn_deleteCustomerInDatabase.Size = new System.Drawing.Size(159, 32);
            this.btn_deleteCustomerInDatabase.TabIndex = 36;
            this.btn_deleteCustomerInDatabase.Text = "Slet Kunde";
            this.btn_deleteCustomerInDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteCustomerInDatabase.Click += new System.EventHandler(this.btn_deleteCustomerInDatabase_Click);
            // 
            // btn_OKShowCostumer
            // 
            this.btn_OKShowCostumer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OKShowCostumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKShowCostumer.Location = new System.Drawing.Point(337, 129);
            this.btn_OKShowCostumer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OKShowCostumer.Name = "btn_OKShowCostumer";
            this.btn_OKShowCostumer.Size = new System.Drawing.Size(247, 32);
            this.btn_OKShowCostumer.TabIndex = 37;
            this.btn_OKShowCostumer.Text = "OK";
            this.btn_OKShowCostumer.UseVisualStyleBackColor = false;
            this.btn_OKShowCostumer.Click += new System.EventHandler(this.btn_OKShowCostumer_Click);
            // 
            // btn_homePageHelp
            // 
            this.btn_homePageHelp.BackColor = System.Drawing.Color.Silver;
            this.btn_homePageHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homePageHelp.Location = new System.Drawing.Point(997, 25);
            this.btn_homePageHelp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_homePageHelp.Name = "btn_homePageHelp";
            this.btn_homePageHelp.Size = new System.Drawing.Size(33, 36);
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
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
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
            // EditCostumerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.btn_homePageHelp);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditCostumerSearchForm";
            this.Text = "Rediger Kunde";
            this.Load += new System.EventHandler(this.EditCostumerSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showCustomerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).EndInit();
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
        private System.Windows.Forms.Button btn_OKShowCostumer;
        private System.Windows.Forms.Button btn_homePageHelp;
        private Saanneeha_dk_db_databaseDataSet saanneeha_dk_db_databaseDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private Saanneeha_dk_db_databaseDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}