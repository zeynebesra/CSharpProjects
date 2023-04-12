
namespace Access_Ingilizce_Kelime_Uygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInglizce = new System.Windows.Forms.TextBox();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBody.BackgroundImage")));
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.Controls.Add(this.groupBox2);
            this.panelBody.Controls.Add(this.groupBox1);
            this.panelBody.Controls.Add(this.LblCevap);
            this.panelBody.Controls.Add(this.TxtTurkce);
            this.panelBody.Controls.Add(this.label2);
            this.panelBody.Controls.Add(this.TxtInglizce);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(591, 437);
            this.panelBody.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(148, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İNGİLİZCE : ";
            // 
            // TxtInglizce
            // 
            this.TxtInglizce.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInglizce.Location = new System.Drawing.Point(251, 189);
            this.TxtInglizce.Multiline = true;
            this.TxtInglizce.Name = "TxtInglizce";
            this.TxtInglizce.Size = new System.Drawing.Size(210, 24);
            this.TxtInglizce.TabIndex = 1;
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTurkce.Location = new System.Drawing.Point(251, 234);
            this.TxtTurkce.Multiline = true;
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(210, 24);
            this.TxtTurkce.TabIndex = 3;
            this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(164, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÜRKÇE : ";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.BackColor = System.Drawing.Color.Transparent;
            this.LblSure.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.ForeColor = System.Drawing.Color.DarkRed;
            this.LblSure.Location = new System.Drawing.Point(51, 21);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(30, 24);
            this.LblSure.TabIndex = 5;
            this.LblSure.Text = "90";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.BackColor = System.Drawing.Color.Transparent;
            this.LblCevap.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LblCevap.Location = new System.Drawing.Point(375, 297);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(86, 31);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "sonuç";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LblSure);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(374, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblKelime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(152, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.BackColor = System.Drawing.Color.Transparent;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKelime.Location = new System.Drawing.Point(67, 20);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(20, 24);
            this.lblKelime.TabIndex = 5;
            this.lblKelime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 437);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtInglizce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

