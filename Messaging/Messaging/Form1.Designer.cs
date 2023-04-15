
namespace Messaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBody = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbMessageDataSet = new Messaging.DbMessageDataSet();
            this.tBLMESAJLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMESAJLARTableAdapter = new Messaging.DbMessageDataSetTableAdapters.TBLMESAJLARTableAdapter();
            this.mESAJIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gONDERENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLICIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASLIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıCERIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gONDERENDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLICIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASLIKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıCERIKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBody.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMessageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMESAJLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBody.BackgroundImage")));
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.Controls.Add(this.lblAdSoyad);
            this.panelBody.Controls.Add(this.lblNumara);
            this.panelBody.Controls.Add(this.label5);
            this.panelBody.Controls.Add(this.label4);
            this.panelBody.Controls.Add(this.groupBox3);
            this.panelBody.Controls.Add(this.groupBox2);
            this.panelBody.Controls.Add(this.groupBox1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(586, 808);
            this.panelBody.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(174, 135);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(15, 19);
            this.lblAdSoyad.TabIndex = 6;
            this.lblAdSoyad.Text = "-";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Location = new System.Drawing.Point(174, 113);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(15, 19);
            this.lblNumara.TabIndex = 5;
            this.lblNumara.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numara : ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(83, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(415, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giden Kutusu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mESAJIDDataGridViewTextBoxColumn1,
            this.gONDERENDataGridViewTextBoxColumn1,
            this.aLICIDataGridViewTextBoxColumn1,
            this.bASLIKDataGridViewTextBoxColumn1,
            this.ıCERIKDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tBLMESAJLARBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(5, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(405, 108);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(87, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(410, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mesaj Paneli";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 37);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 25);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(72, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 73);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(72, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(316, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Gönder";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesaj :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(82, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(415, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelen Kutusu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mESAJIDDataGridViewTextBoxColumn,
            this.gONDERENDataGridViewTextBoxColumn,
            this.aLICIDataGridViewTextBoxColumn,
            this.bASLIKDataGridViewTextBoxColumn,
            this.ıCERIKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMESAJLARBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 107);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbMessageDataSet
            // 
            this.dbMessageDataSet.DataSetName = "DbMessageDataSet";
            this.dbMessageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMESAJLARBindingSource
            // 
            this.tBLMESAJLARBindingSource.DataMember = "TBLMESAJLAR";
            this.tBLMESAJLARBindingSource.DataSource = this.dbMessageDataSet;
            // 
            // tBLMESAJLARTableAdapter
            // 
            this.tBLMESAJLARTableAdapter.ClearBeforeFill = true;
            // 
            // mESAJIDDataGridViewTextBoxColumn
            // 
            this.mESAJIDDataGridViewTextBoxColumn.DataPropertyName = "MESAJID";
            this.mESAJIDDataGridViewTextBoxColumn.HeaderText = "MESAJID";
            this.mESAJIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mESAJIDDataGridViewTextBoxColumn.Name = "mESAJIDDataGridViewTextBoxColumn";
            this.mESAJIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gONDERENDataGridViewTextBoxColumn
            // 
            this.gONDERENDataGridViewTextBoxColumn.DataPropertyName = "GONDEREN";
            this.gONDERENDataGridViewTextBoxColumn.HeaderText = "GONDEREN";
            this.gONDERENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gONDERENDataGridViewTextBoxColumn.Name = "gONDERENDataGridViewTextBoxColumn";
            // 
            // aLICIDataGridViewTextBoxColumn
            // 
            this.aLICIDataGridViewTextBoxColumn.DataPropertyName = "ALICI";
            this.aLICIDataGridViewTextBoxColumn.HeaderText = "ALICI";
            this.aLICIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLICIDataGridViewTextBoxColumn.Name = "aLICIDataGridViewTextBoxColumn";
            // 
            // bASLIKDataGridViewTextBoxColumn
            // 
            this.bASLIKDataGridViewTextBoxColumn.DataPropertyName = "BASLIK";
            this.bASLIKDataGridViewTextBoxColumn.HeaderText = "BASLIK";
            this.bASLIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bASLIKDataGridViewTextBoxColumn.Name = "bASLIKDataGridViewTextBoxColumn";
            // 
            // ıCERIKDataGridViewTextBoxColumn
            // 
            this.ıCERIKDataGridViewTextBoxColumn.DataPropertyName = "ICERIK";
            this.ıCERIKDataGridViewTextBoxColumn.HeaderText = "ICERIK";
            this.ıCERIKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıCERIKDataGridViewTextBoxColumn.Name = "ıCERIKDataGridViewTextBoxColumn";
            // 
            // mESAJIDDataGridViewTextBoxColumn1
            // 
            this.mESAJIDDataGridViewTextBoxColumn1.DataPropertyName = "MESAJID";
            this.mESAJIDDataGridViewTextBoxColumn1.HeaderText = "MESAJID";
            this.mESAJIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mESAJIDDataGridViewTextBoxColumn1.Name = "mESAJIDDataGridViewTextBoxColumn1";
            this.mESAJIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gONDERENDataGridViewTextBoxColumn1
            // 
            this.gONDERENDataGridViewTextBoxColumn1.DataPropertyName = "GONDEREN";
            this.gONDERENDataGridViewTextBoxColumn1.HeaderText = "GONDEREN";
            this.gONDERENDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.gONDERENDataGridViewTextBoxColumn1.Name = "gONDERENDataGridViewTextBoxColumn1";
            // 
            // aLICIDataGridViewTextBoxColumn1
            // 
            this.aLICIDataGridViewTextBoxColumn1.DataPropertyName = "ALICI";
            this.aLICIDataGridViewTextBoxColumn1.HeaderText = "ALICI";
            this.aLICIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aLICIDataGridViewTextBoxColumn1.Name = "aLICIDataGridViewTextBoxColumn1";
            // 
            // bASLIKDataGridViewTextBoxColumn1
            // 
            this.bASLIKDataGridViewTextBoxColumn1.DataPropertyName = "BASLIK";
            this.bASLIKDataGridViewTextBoxColumn1.HeaderText = "BASLIK";
            this.bASLIKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bASLIKDataGridViewTextBoxColumn1.Name = "bASLIKDataGridViewTextBoxColumn1";
            // 
            // ıCERIKDataGridViewTextBoxColumn1
            // 
            this.ıCERIKDataGridViewTextBoxColumn1.DataPropertyName = "ICERIK";
            this.ıCERIKDataGridViewTextBoxColumn1.HeaderText = "ICERIK";
            this.ıCERIKDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıCERIKDataGridViewTextBoxColumn1.Name = "ıCERIKDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 808);
            this.Controls.Add(this.panelBody);
            this.Name = "Form1";
            this.Text = " Mesajlaşma Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMessageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMESAJLARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DbMessageDataSet dbMessageDataSet;
        private System.Windows.Forms.BindingSource tBLMESAJLARBindingSource;
        private DbMessageDataSetTableAdapters.TBLMESAJLARTableAdapter tBLMESAJLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gONDERENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLICIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASLIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCERIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gONDERENDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLICIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASLIKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCERIKDataGridViewTextBoxColumn1;
    }
}

