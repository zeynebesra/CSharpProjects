
namespace Urun_Takip_Sorgulama
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbMagazaDataSet = new Urun_Takip_Sorgulama.DbMagazaDataSet();
            this.dbMagazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMagazaTableAdapter = new Urun_Takip_Sorgulama.DbMagazaDataSetTableAdapters.DbMagazaTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fıyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMagazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMagazaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.aDSOYADDataGridViewTextBoxColumn,
            this.aD1DataGridViewTextBoxColumn,
            this.fıyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbMagazaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbMagazaDataSet
            // 
            this.dbMagazaDataSet.DataSetName = "DbMagazaDataSet";
            this.dbMagazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbMagazaBindingSource
            // 
            this.dbMagazaBindingSource.DataMember = "DbMagaza";
            this.dbMagazaBindingSource.DataSource = this.dbMagazaDataSet;
            // 
            // dbMagazaTableAdapter
            // 
            this.dbMagazaTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // aDSOYADDataGridViewTextBoxColumn
            // 
            this.aDSOYADDataGridViewTextBoxColumn.DataPropertyName = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.HeaderText = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDSOYADDataGridViewTextBoxColumn.Name = "aDSOYADDataGridViewTextBoxColumn";
            // 
            // aD1DataGridViewTextBoxColumn
            // 
            this.aD1DataGridViewTextBoxColumn.DataPropertyName = "AD1";
            this.aD1DataGridViewTextBoxColumn.HeaderText = "AD1";
            this.aD1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aD1DataGridViewTextBoxColumn.Name = "aD1DataGridViewTextBoxColumn";
            // 
            // fıyatDataGridViewTextBoxColumn
            // 
            this.fıyatDataGridViewTextBoxColumn.DataPropertyName = "fıyat";
            this.fıyatDataGridViewTextBoxColumn.HeaderText = "fıyat";
            this.fıyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fıyatDataGridViewTextBoxColumn.Name = "fıyatDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 342);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "İlişkili Veri Tabanı Hareket Tablo ve Sorgulama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMagazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMagazaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbMagazaDataSet dbMagazaDataSet;
        private System.Windows.Forms.BindingSource dbMagazaBindingSource;
        private DbMagazaDataSetTableAdapters.DbMagazaTableAdapter dbMagazaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fıyatDataGridViewTextBoxColumn;
    }
}

