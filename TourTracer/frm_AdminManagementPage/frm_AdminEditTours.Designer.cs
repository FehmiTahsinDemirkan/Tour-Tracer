﻿namespace TourTracer
{
    partial class frm_AdminEditTours
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tourTracerDataSet6 = new TourTracer.TourTracerDataSet6();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CitiesTableAdapter = new TourTracer.TourTracerDataSet6TableAdapters.tbl_CitiesTableAdapter();
            this.tourTracerDataSet9 = new TourTracer.TourTracerDataSet9();
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter = new TourTracer.TourTracerDataSet9TableAdapters.tbl_ToursTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(424, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TURLARI DÜZENLE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 89);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tur Seç";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(271, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(340, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tur Güzergahını Seç";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(378, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tur Bilgilerini Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(216, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 64);
            this.button2.TabIndex = 7;
            this.button2.Text = "GERİ DÖN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 302);
            this.dataGridView1.TabIndex = 8;
            // 
            // tourTracerDataSet6
            // 
            this.tourTracerDataSet6.DataSetName = "TourTracerDataSet6";
            this.tourTracerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tbl_Cities";
            this.tblCitiesBindingSource.DataSource = this.tourTracerDataSet6;
            // 
            // tbl_CitiesTableAdapter
            // 
            this.tbl_CitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tourTracerDataSet9
            // 
            this.tourTracerDataSet9.DataSetName = "TourTracerDataSet9";
            this.tourTracerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToursBindingSource
            // 
            this.tblToursBindingSource.DataMember = "tbl_Tours";
            this.tblToursBindingSource.DataSource = this.tourTracerDataSet9;
            // 
            // tbl_ToursTableAdapter
            // 
            this.tbl_ToursTableAdapter.ClearBeforeFill = true;
            // 
            // frm_AdminEditTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminEditTours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EditSelectedTours";
            this.Load += new System.EventHandler(this.frm_EditSelectedTours_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourTracerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TourTracerDataSet6 tourTracerDataSet6;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private TourTracerDataSet6TableAdapters.tbl_CitiesTableAdapter tbl_CitiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TourTracerDataSet9 tourTracerDataSet9;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourTracerDataSet9TableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
    }
}