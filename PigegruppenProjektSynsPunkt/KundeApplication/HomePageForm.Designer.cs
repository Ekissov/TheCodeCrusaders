namespace KundeApplication
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NextBt_6 = new System.Windows.Forms.Button();
            this.RB_ThicknessTHICK = new System.Windows.Forms.RadioButton();
            this.RB_ThicknessTHIN = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NextBt_5 = new System.Windows.Forms.Button();
            this.RB_NosePadsYES = new System.Windows.Forms.RadioButton();
            this.RB_NosePadsNO = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NextBt_4 = new System.Windows.Forms.Button();
            this.RB_PatternNO = new System.Windows.Forms.RadioButton();
            this.RB_PatternYES = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NextBt_3 = new System.Windows.Forms.Button();
            this.RB_FaconSquare = new System.Windows.Forms.RadioButton();
            this.RB_FaconRound = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NextBt_2 = new System.Windows.Forms.Button();
            this.RB_ColourBlack = new System.Windows.Forms.RadioButton();
            this.RB_ColourRed = new System.Windows.Forms.RadioButton();
            this.RB_ColourTransparent = new System.Windows.Forms.RadioButton();
            this.RB_ColourBrown = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_MaxPrice8000 = new System.Windows.Forms.RadioButton();
            this.NextBt_1 = new System.Windows.Forms.Button();
            this.RB_MaxPrice5000 = new System.Windows.Forms.RadioButton();
            this.RB_MaxPrice1500 = new System.Windows.Forms.RadioButton();
            this.RB_MaxPrice3000 = new System.Windows.Forms.RadioButton();
            this.Dgv_Frames = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameColourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameFaconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameThicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosePadsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framePatternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saanneeha_dk_db_databaseDataSet = new KundeApplication.Saanneeha_dk_db_databaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frameTableAdapter = new KundeApplication.Saanneeha_dk_db_databaseDataSetTableAdapters.FrameTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Frames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spørgsmål til din kommende brille!";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.NextBt_6);
            this.groupBox7.Controls.Add(this.RB_ThicknessTHICK);
            this.groupBox7.Controls.Add(this.RB_ThicknessTHIN);
            this.groupBox7.Location = new System.Drawing.Point(6, 524);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(337, 57);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "6. Skal stellet være tykt eller tyndt?";
            // 
            // NextBt_6
            // 
            this.NextBt_6.Location = new System.Drawing.Point(271, 22);
            this.NextBt_6.Name = "NextBt_6";
            this.NextBt_6.Size = new System.Drawing.Size(66, 28);
            this.NextBt_6.TabIndex = 20;
            this.NextBt_6.Text = "OK";
            this.NextBt_6.UseVisualStyleBackColor = true;
            this.NextBt_6.Click += new System.EventHandler(this.NextBt_6_Click);
            // 
            // RB_ThicknessTHICK
            // 
            this.RB_ThicknessTHICK.AutoSize = true;
            this.RB_ThicknessTHICK.Location = new System.Drawing.Point(6, 26);
            this.RB_ThicknessTHICK.Name = "RB_ThicknessTHICK";
            this.RB_ThicknessTHICK.Size = new System.Drawing.Size(61, 24);
            this.RB_ThicknessTHICK.TabIndex = 20;
            this.RB_ThicknessTHICK.TabStop = true;
            this.RB_ThicknessTHICK.Text = "Tykt";
            this.RB_ThicknessTHICK.UseVisualStyleBackColor = true;
            // 
            // RB_ThicknessTHIN
            // 
            this.RB_ThicknessTHIN.AutoSize = true;
            this.RB_ThicknessTHIN.Location = new System.Drawing.Point(123, 26);
            this.RB_ThicknessTHIN.Name = "RB_ThicknessTHIN";
            this.RB_ThicknessTHIN.Size = new System.Drawing.Size(71, 24);
            this.RB_ThicknessTHIN.TabIndex = 21;
            this.RB_ThicknessTHIN.TabStop = true;
            this.RB_ThicknessTHIN.Text = "Tyndt";
            this.RB_ThicknessTHIN.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NextBt_5);
            this.groupBox6.Controls.Add(this.RB_NosePadsYES);
            this.groupBox6.Controls.Add(this.RB_NosePadsNO);
            this.groupBox6.Location = new System.Drawing.Point(6, 416);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 102);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "5. Skal stellet have næsepuder?";
            // 
            // NextBt_5
            // 
            this.NextBt_5.Location = new System.Drawing.Point(271, 44);
            this.NextBt_5.Name = "NextBt_5";
            this.NextBt_5.Size = new System.Drawing.Size(66, 28);
            this.NextBt_5.TabIndex = 18;
            this.NextBt_5.Text = "OK";
            this.NextBt_5.UseVisualStyleBackColor = true;
            this.NextBt_5.Click += new System.EventHandler(this.NextBt_5_Click);
            // 
            // RB_NosePadsYES
            // 
            this.RB_NosePadsYES.AutoSize = true;
            this.RB_NosePadsYES.Location = new System.Drawing.Point(6, 35);
            this.RB_NosePadsYES.Name = "RB_NosePadsYES";
            this.RB_NosePadsYES.Size = new System.Drawing.Size(153, 24);
            this.RB_NosePadsYES.TabIndex = 18;
            this.RB_NosePadsYES.TabStop = true;
            this.RB_NosePadsYES.Text = "Med Næsepuder";
            this.RB_NosePadsYES.UseVisualStyleBackColor = true;
            // 
            // RB_NosePadsNO
            // 
            this.RB_NosePadsNO.AutoSize = true;
            this.RB_NosePadsNO.Location = new System.Drawing.Point(6, 65);
            this.RB_NosePadsNO.Name = "RB_NosePadsNO";
            this.RB_NosePadsNO.Size = new System.Drawing.Size(160, 24);
            this.RB_NosePadsNO.TabIndex = 19;
            this.RB_NosePadsNO.TabStop = true;
            this.RB_NosePadsNO.Text = "Uden Næsepuder";
            this.RB_NosePadsNO.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NextBt_4);
            this.groupBox5.Controls.Add(this.RB_PatternNO);
            this.groupBox5.Controls.Add(this.RB_PatternYES);
            this.groupBox5.Location = new System.Drawing.Point(6, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4. Hvordan har du det med mønstret stel?";
            // 
            // NextBt_4
            // 
            this.NextBt_4.Location = new System.Drawing.Point(271, 48);
            this.NextBt_4.Name = "NextBt_4";
            this.NextBt_4.Size = new System.Drawing.Size(66, 28);
            this.NextBt_4.TabIndex = 16;
            this.NextBt_4.Text = "OK";
            this.NextBt_4.UseVisualStyleBackColor = true;
            this.NextBt_4.Click += new System.EventHandler(this.NextBt_4_Click);
            // 
            // RB_PatternNO
            // 
            this.RB_PatternNO.AutoSize = true;
            this.RB_PatternNO.Location = new System.Drawing.Point(123, 48);
            this.RB_PatternNO.Name = "RB_PatternNO";
            this.RB_PatternNO.Size = new System.Drawing.Size(128, 24);
            this.RB_PatternNO.TabIndex = 17;
            this.RB_PatternNO.TabStop = true;
            this.RB_PatternNO.Text = "Intet Mønster";
            this.RB_PatternNO.UseVisualStyleBackColor = true;
            // 
            // RB_PatternYES
            // 
            this.RB_PatternYES.AutoSize = true;
            this.RB_PatternYES.Location = new System.Drawing.Point(6, 48);
            this.RB_PatternYES.Name = "RB_PatternYES";
            this.RB_PatternYES.Size = new System.Drawing.Size(91, 24);
            this.RB_PatternYES.TabIndex = 16;
            this.RB_PatternYES.TabStop = true;
            this.RB_PatternYES.Text = "Mønster";
            this.RB_PatternYES.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NextBt_3);
            this.groupBox4.Controls.Add(this.RB_FaconSquare);
            this.groupBox4.Controls.Add(this.RB_FaconRound);
            this.groupBox4.Location = new System.Drawing.Point(6, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 69);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Hvilken facon skal stellet have?";
            // 
            // NextBt_3
            // 
            this.NextBt_3.Location = new System.Drawing.Point(271, 26);
            this.NextBt_3.Name = "NextBt_3";
            this.NextBt_3.Size = new System.Drawing.Size(66, 28);
            this.NextBt_3.TabIndex = 14;
            this.NextBt_3.Text = "OK";
            this.NextBt_3.UseVisualStyleBackColor = true;
            this.NextBt_3.Click += new System.EventHandler(this.NextBt_3_Click);
            // 
            // RB_FaconSquare
            // 
            this.RB_FaconSquare.AutoSize = true;
            this.RB_FaconSquare.Location = new System.Drawing.Point(123, 26);
            this.RB_FaconSquare.Name = "RB_FaconSquare";
            this.RB_FaconSquare.Size = new System.Drawing.Size(95, 24);
            this.RB_FaconSquare.TabIndex = 15;
            this.RB_FaconSquare.TabStop = true;
            this.RB_FaconSquare.Text = "Firkantet";
            this.RB_FaconSquare.UseVisualStyleBackColor = true;
            // 
            // RB_FaconRound
            // 
            this.RB_FaconRound.AutoSize = true;
            this.RB_FaconRound.Location = new System.Drawing.Point(6, 26);
            this.RB_FaconRound.Name = "RB_FaconRound";
            this.RB_FaconRound.Size = new System.Drawing.Size(69, 24);
            this.RB_FaconRound.TabIndex = 14;
            this.RB_FaconRound.TabStop = true;
            this.RB_FaconRound.Text = "Rund";
            this.RB_FaconRound.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NextBt_2);
            this.groupBox3.Controls.Add(this.RB_ColourBlack);
            this.groupBox3.Controls.Add(this.RB_ColourRed);
            this.groupBox3.Controls.Add(this.RB_ColourTransparent);
            this.groupBox3.Controls.Add(this.RB_ColourBrown);
            this.groupBox3.Location = new System.Drawing.Point(6, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Hvilken farve skal dit brillestel være?";
            // 
            // NextBt_2
            // 
            this.NextBt_2.Location = new System.Drawing.Point(271, 45);
            this.NextBt_2.Name = "NextBt_2";
            this.NextBt_2.Size = new System.Drawing.Size(66, 26);
            this.NextBt_2.TabIndex = 5;
            this.NextBt_2.Text = "OK";
            this.NextBt_2.UseVisualStyleBackColor = true;
            this.NextBt_2.Click += new System.EventHandler(this.NextBt_2_Click);
            // 
            // RB_ColourBlack
            // 
            this.RB_ColourBlack.AutoSize = true;
            this.RB_ColourBlack.Location = new System.Drawing.Point(6, 26);
            this.RB_ColourBlack.Name = "RB_ColourBlack";
            this.RB_ColourBlack.Size = new System.Drawing.Size(61, 24);
            this.RB_ColourBlack.TabIndex = 10;
            this.RB_ColourBlack.TabStop = true;
            this.RB_ColourBlack.Text = "Sort";
            this.RB_ColourBlack.UseVisualStyleBackColor = true;
            // 
            // RB_ColourRed
            // 
            this.RB_ColourRed.AutoSize = true;
            this.RB_ColourRed.Location = new System.Drawing.Point(6, 56);
            this.RB_ColourRed.Name = "RB_ColourRed";
            this.RB_ColourRed.Size = new System.Drawing.Size(60, 24);
            this.RB_ColourRed.TabIndex = 12;
            this.RB_ColourRed.TabStop = true;
            this.RB_ColourRed.Text = "Rød";
            this.RB_ColourRed.UseVisualStyleBackColor = true;
            // 
            // RB_ColourTransparent
            // 
            this.RB_ColourTransparent.AutoSize = true;
            this.RB_ColourTransparent.Location = new System.Drawing.Point(123, 26);
            this.RB_ColourTransparent.Name = "RB_ColourTransparent";
            this.RB_ColourTransparent.Size = new System.Drawing.Size(133, 24);
            this.RB_ColourTransparent.TabIndex = 11;
            this.RB_ColourTransparent.TabStop = true;
            this.RB_ColourTransparent.Text = "Gennemsigtig";
            this.RB_ColourTransparent.UseVisualStyleBackColor = true;
            // 
            // RB_ColourBrown
            // 
            this.RB_ColourBrown.AutoSize = true;
            this.RB_ColourBrown.Location = new System.Drawing.Point(123, 56);
            this.RB_ColourBrown.Name = "RB_ColourBrown";
            this.RB_ColourBrown.Size = new System.Drawing.Size(66, 24);
            this.RB_ColourBrown.TabIndex = 13;
            this.RB_ColourBrown.TabStop = true;
            this.RB_ColourBrown.Text = "Brun";
            this.RB_ColourBrown.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_MaxPrice8000);
            this.groupBox2.Controls.Add(this.NextBt_1);
            this.groupBox2.Controls.Add(this.RB_MaxPrice5000);
            this.groupBox2.Controls.Add(this.RB_MaxPrice1500);
            this.groupBox2.Controls.Add(this.RB_MaxPrice3000);
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Hvad er maksimal pris på stel?";
            // 
            // RB_MaxPrice8000
            // 
            this.RB_MaxPrice8000.AutoSize = true;
            this.RB_MaxPrice8000.Location = new System.Drawing.Point(123, 56);
            this.RB_MaxPrice8000.Name = "RB_MaxPrice8000";
            this.RB_MaxPrice8000.Size = new System.Drawing.Size(95, 24);
            this.RB_MaxPrice8000.TabIndex = 9;
            this.RB_MaxPrice8000.TabStop = true;
            this.RB_MaxPrice8000.Text = "8000+ kr";
            this.RB_MaxPrice8000.UseVisualStyleBackColor = true;
            // 
            // NextBt_1
            // 
            this.NextBt_1.Location = new System.Drawing.Point(271, 37);
            this.NextBt_1.Name = "NextBt_1";
            this.NextBt_1.Size = new System.Drawing.Size(66, 29);
            this.NextBt_1.TabIndex = 4;
            this.NextBt_1.Text = "OK";
            this.NextBt_1.UseVisualStyleBackColor = true;
            this.NextBt_1.Click += new System.EventHandler(this.NextBt_1_Click);
            // 
            // RB_MaxPrice5000
            // 
            this.RB_MaxPrice5000.AutoSize = true;
            this.RB_MaxPrice5000.Location = new System.Drawing.Point(6, 56);
            this.RB_MaxPrice5000.Name = "RB_MaxPrice5000";
            this.RB_MaxPrice5000.Size = new System.Drawing.Size(85, 24);
            this.RB_MaxPrice5000.TabIndex = 8;
            this.RB_MaxPrice5000.TabStop = true;
            this.RB_MaxPrice5000.Text = "5000 kr";
            this.RB_MaxPrice5000.UseVisualStyleBackColor = true;
            // 
            // RB_MaxPrice1500
            // 
            this.RB_MaxPrice1500.AutoSize = true;
            this.RB_MaxPrice1500.Location = new System.Drawing.Point(6, 26);
            this.RB_MaxPrice1500.Name = "RB_MaxPrice1500";
            this.RB_MaxPrice1500.Size = new System.Drawing.Size(85, 24);
            this.RB_MaxPrice1500.TabIndex = 6;
            this.RB_MaxPrice1500.TabStop = true;
            this.RB_MaxPrice1500.Text = "1500 kr";
            this.RB_MaxPrice1500.UseVisualStyleBackColor = true;
            // 
            // RB_MaxPrice3000
            // 
            this.RB_MaxPrice3000.AutoSize = true;
            this.RB_MaxPrice3000.Location = new System.Drawing.Point(123, 26);
            this.RB_MaxPrice3000.Name = "RB_MaxPrice3000";
            this.RB_MaxPrice3000.Size = new System.Drawing.Size(85, 24);
            this.RB_MaxPrice3000.TabIndex = 7;
            this.RB_MaxPrice3000.TabStop = true;
            this.RB_MaxPrice3000.Text = "3000 kr";
            this.RB_MaxPrice3000.UseVisualStyleBackColor = true;
            // 
            // Dgv_Frames
            // 
            this.Dgv_Frames.AutoGenerateColumns = false;
            this.Dgv_Frames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Frames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.frameColourDataGridViewTextBoxColumn,
            this.frameFaconDataGridViewTextBoxColumn,
            this.frameThicknessDataGridViewTextBoxColumn,
            this.nosePadsDataGridViewTextBoxColumn,
            this.framePatternDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.Dgv_Frames.DataSource = this.frameBindingSource;
            this.Dgv_Frames.Location = new System.Drawing.Point(378, 332);
            this.Dgv_Frames.Name = "Dgv_Frames";
            this.Dgv_Frames.RowHeadersWidth = 51;
            this.Dgv_Frames.RowTemplate.Height = 24;
            this.Dgv_Frames.Size = new System.Drawing.Size(1036, 237);
            this.Dgv_Frames.TabIndex = 1;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // frameColourDataGridViewTextBoxColumn
            // 
            this.frameColourDataGridViewTextBoxColumn.DataPropertyName = "FrameColour";
            this.frameColourDataGridViewTextBoxColumn.HeaderText = "FrameColour";
            this.frameColourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frameColourDataGridViewTextBoxColumn.Name = "frameColourDataGridViewTextBoxColumn";
            this.frameColourDataGridViewTextBoxColumn.Width = 125;
            // 
            // frameFaconDataGridViewTextBoxColumn
            // 
            this.frameFaconDataGridViewTextBoxColumn.DataPropertyName = "FrameFacon";
            this.frameFaconDataGridViewTextBoxColumn.HeaderText = "FrameFacon";
            this.frameFaconDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frameFaconDataGridViewTextBoxColumn.Name = "frameFaconDataGridViewTextBoxColumn";
            this.frameFaconDataGridViewTextBoxColumn.Width = 80;
            // 
            // frameThicknessDataGridViewTextBoxColumn
            // 
            this.frameThicknessDataGridViewTextBoxColumn.DataPropertyName = "FrameThickness";
            this.frameThicknessDataGridViewTextBoxColumn.HeaderText = "Thickness";
            this.frameThicknessDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frameThicknessDataGridViewTextBoxColumn.Name = "frameThicknessDataGridViewTextBoxColumn";
            this.frameThicknessDataGridViewTextBoxColumn.Width = 75;
            // 
            // nosePadsDataGridViewTextBoxColumn
            // 
            this.nosePadsDataGridViewTextBoxColumn.DataPropertyName = "NosePads";
            this.nosePadsDataGridViewTextBoxColumn.HeaderText = "NosePads";
            this.nosePadsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nosePadsDataGridViewTextBoxColumn.Name = "nosePadsDataGridViewTextBoxColumn";
            this.nosePadsDataGridViewTextBoxColumn.Width = 125;
            // 
            // framePatternDataGridViewTextBoxColumn
            // 
            this.framePatternDataGridViewTextBoxColumn.DataPropertyName = "FramePattern";
            this.framePatternDataGridViewTextBoxColumn.HeaderText = "Pattern";
            this.framePatternDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.framePatternDataGridViewTextBoxColumn.Name = "framePatternDataGridViewTextBoxColumn";
            this.framePatternDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // frameBindingSource
            // 
            this.frameBindingSource.DataMember = "Frame";
            this.frameBindingSource.DataSource = this.saanneeha_dk_db_databaseDataSet;
            // 
            // saanneeha_dk_db_databaseDataSet
            // 
            this.saanneeha_dk_db_databaseDataSet.DataSetName = "Saanneeha_dk_db_databaseDataSet";
            this.saanneeha_dk_db_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 314);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frameTableAdapter
            // 
            this.frameTableAdapter.ClearBeforeFill = true;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dgv_Frames);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Frames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saanneeha_dk_db_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_Frames;
        private System.Windows.Forms.RadioButton RB_ColourBrown;
        private System.Windows.Forms.RadioButton RB_ColourRed;
        private System.Windows.Forms.RadioButton RB_ColourTransparent;
        private System.Windows.Forms.RadioButton RB_ColourBlack;
        private System.Windows.Forms.RadioButton RB_MaxPrice8000;
        private System.Windows.Forms.RadioButton RB_MaxPrice5000;
        private System.Windows.Forms.RadioButton RB_MaxPrice3000;
        private System.Windows.Forms.RadioButton RB_MaxPrice1500;
        private System.Windows.Forms.RadioButton RB_NosePadsYES;
        private System.Windows.Forms.RadioButton RB_PatternNO;
        private System.Windows.Forms.RadioButton RB_PatternYES;
        private System.Windows.Forms.RadioButton RB_FaconSquare;
        private System.Windows.Forms.RadioButton RB_FaconRound;
        private System.Windows.Forms.RadioButton RB_ThicknessTHIN;
        private System.Windows.Forms.RadioButton RB_ThicknessTHICK;
        private System.Windows.Forms.RadioButton RB_NosePadsNO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Saanneeha_dk_db_databaseDataSet saanneeha_dk_db_databaseDataSet;
        private System.Windows.Forms.BindingSource frameBindingSource;
        private Saanneeha_dk_db_databaseDataSetTableAdapters.FrameTableAdapter frameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameColourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameFaconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameThicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosePadsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn framePatternDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button NextBt_3;
        private System.Windows.Forms.Button NextBt_2;
        private System.Windows.Forms.Button NextBt_1;
        private System.Windows.Forms.Button NextBt_6;
        private System.Windows.Forms.Button NextBt_5;
        private System.Windows.Forms.Button NextBt_4;
    }
}

