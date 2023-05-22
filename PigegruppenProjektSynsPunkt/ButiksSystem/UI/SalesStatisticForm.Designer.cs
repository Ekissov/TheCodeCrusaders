﻿namespace ButiksSystem.UI
{
    partial class SalesStatisticForm
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
            this.btn_salesStatisicsShowAllSales = new System.Windows.Forms.Button();
            this.dgv_showSalesStatisticsInDatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_salesStatisticsStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_salesStatisticsEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salesStatisticsPrintToTxtFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showSalesStatisticsInDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salesStatisicsShowAllSales
            // 
            this.btn_salesStatisicsShowAllSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesStatisicsShowAllSales.Location = new System.Drawing.Point(610, 270);
            this.btn_salesStatisicsShowAllSales.Name = "btn_salesStatisicsShowAllSales";
            this.btn_salesStatisicsShowAllSales.Size = new System.Drawing.Size(200, 38);
            this.btn_salesStatisicsShowAllSales.TabIndex = 0;
            this.btn_salesStatisicsShowAllSales.Text = "Vis alle Salg";
            this.btn_salesStatisicsShowAllSales.UseVisualStyleBackColor = true;
            this.btn_salesStatisicsShowAllSales.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_showSalesStatisticsInDatagrid
            // 
            this.dgv_showSalesStatisticsInDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showSalesStatisticsInDatagrid.Location = new System.Drawing.Point(31, 76);
            this.dgv_showSalesStatisticsInDatagrid.Name = "dgv_showSalesStatisticsInDatagrid";
            this.dgv_showSalesStatisticsInDatagrid.RowHeadersWidth = 51;
            this.dgv_showSalesStatisticsInDatagrid.Size = new System.Drawing.Size(413, 326);
            this.dgv_showSalesStatisticsInDatagrid.TabIndex = 1;
            this.dgv_showSalesStatisticsInDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salgsstatistik";
            // 
            // dtp_salesStatisticsStartDate
            // 
            this.dtp_salesStatisticsStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_salesStatisticsStartDate.Location = new System.Drawing.Point(610, 115);
            this.dtp_salesStatisticsStartDate.Name = "dtp_salesStatisticsStartDate";
            this.dtp_salesStatisticsStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_salesStatisticsStartDate.TabIndex = 3;
            // 
            // dtp_salesStatisticsEndDate
            // 
            this.dtp_salesStatisticsEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_salesStatisticsEndDate.Location = new System.Drawing.Point(610, 170);
            this.dtp_salesStatisticsEndDate.Name = "dtp_salesStatisticsEndDate";
            this.dtp_salesStatisticsEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_salesStatisticsEndDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vælg slut dato :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vælg start dato: ";
            // 
            // btn_salesStatisticsPrintToTxtFile
            // 
            this.btn_salesStatisticsPrintToTxtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesStatisticsPrintToTxtFile.Location = new System.Drawing.Point(610, 332);
            this.btn_salesStatisticsPrintToTxtFile.Name = "btn_salesStatisticsPrintToTxtFile";
            this.btn_salesStatisticsPrintToTxtFile.Size = new System.Drawing.Size(200, 38);
            this.btn_salesStatisticsPrintToTxtFile.TabIndex = 7;
            this.btn_salesStatisticsPrintToTxtFile.Text = "Print til Tekstfil";
            this.btn_salesStatisticsPrintToTxtFile.UseVisualStyleBackColor = true;
            // 
            // SalesStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btn_salesStatisticsPrintToTxtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_salesStatisticsEndDate);
            this.Controls.Add(this.dtp_salesStatisticsStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_showSalesStatisticsInDatagrid);
            this.Controls.Add(this.btn_salesStatisicsShowAllSales);
            this.Name = "SalesStatistic";
            this.Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showSalesStatisticsInDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salesStatisicsShowAllSales;
        private System.Windows.Forms.DataGridView dgv_showSalesStatisticsInDatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_salesStatisticsStartDate;
        private System.Windows.Forms.DateTimePicker dtp_salesStatisticsEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salesStatisticsPrintToTxtFile;
    }
}