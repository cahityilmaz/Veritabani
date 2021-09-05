namespace Veritabani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVeritabaniOlustur = new System.Windows.Forms.Button();
            this.txtVeritabaniAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTabloGuncelle = new System.Windows.Forms.Button();
            this.btnTabloOlustur = new System.Windows.Forms.Button();
            this.cmbVeritabaniSec = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(499, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yedekleme / Geri Yükleme";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Veritabanı İşlemleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVeritabaniAdi);
            this.groupBox1.Controls.Add(this.btnVeritabaniOlustur);
            this.groupBox1.Location = new System.Drawing.Point(46, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Oluştur";
            // 
            // btnVeritabaniOlustur
            // 
            this.btnVeritabaniOlustur.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeritabaniOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeritabaniOlustur.ForeColor = System.Drawing.Color.Black;
            this.btnVeritabaniOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeritabaniOlustur.Location = new System.Drawing.Point(234, 51);
            this.btnVeritabaniOlustur.Name = "btnVeritabaniOlustur";
            this.btnVeritabaniOlustur.Size = new System.Drawing.Size(127, 27);
            this.btnVeritabaniOlustur.TabIndex = 1;
            this.btnVeritabaniOlustur.Text = "Veritabanı Oluştur";
            this.btnVeritabaniOlustur.UseVisualStyleBackColor = true;
            this.btnVeritabaniOlustur.Click += new System.EventHandler(this.btnVeritabaniOlustur_Click);
            // 
            // txtVeritabaniAdi
            // 
            this.txtVeritabaniAdi.ForeColor = System.Drawing.Color.Black;
            this.txtVeritabaniAdi.Location = new System.Drawing.Point(22, 51);
            this.txtVeritabaniAdi.Name = "txtVeritabaniAdi";
            this.txtVeritabaniAdi.Size = new System.Drawing.Size(187, 22);
            this.txtVeritabaniAdi.TabIndex = 0;
            this.txtVeritabaniAdi.Click += new System.EventHandler(this.textBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVeritabaniSec);
            this.groupBox2.Controls.Add(this.btnTabloOlustur);
            this.groupBox2.Controls.Add(this.btnTabloGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(46, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablo Oluştur / Güncelle";
            // 
            // btnTabloGuncelle
            // 
            this.btnTabloGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTabloGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabloGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnTabloGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabloGuncelle.Location = new System.Drawing.Point(234, 71);
            this.btnTabloGuncelle.Name = "btnTabloGuncelle";
            this.btnTabloGuncelle.Size = new System.Drawing.Size(127, 27);
            this.btnTabloGuncelle.TabIndex = 2;
            this.btnTabloGuncelle.Text = "Tabloları Güncelle";
            this.btnTabloGuncelle.UseVisualStyleBackColor = true;
            this.btnTabloGuncelle.Click += new System.EventHandler(this.btnTabloGuncelle_Click);
            // 
            // btnTabloOlustur
            // 
            this.btnTabloOlustur.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTabloOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabloOlustur.ForeColor = System.Drawing.Color.Black;
            this.btnTabloOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabloOlustur.Location = new System.Drawing.Point(234, 38);
            this.btnTabloOlustur.Name = "btnTabloOlustur";
            this.btnTabloOlustur.Size = new System.Drawing.Size(127, 27);
            this.btnTabloOlustur.TabIndex = 1;
            this.btnTabloOlustur.Text = "Tabloları Oluştur";
            this.btnTabloOlustur.UseVisualStyleBackColor = true;
            this.btnTabloOlustur.Click += new System.EventHandler(this.btnTabloOlustur_Click);
            // 
            // cmbVeritabaniSec
            // 
            this.cmbVeritabaniSec.ForeColor = System.Drawing.Color.Black;
            this.cmbVeritabaniSec.FormattingEnabled = true;
            this.cmbVeritabaniSec.Location = new System.Drawing.Point(22, 38);
            this.cmbVeritabaniSec.Name = "cmbVeritabaniSec";
            this.cmbVeritabaniSec.Size = new System.Drawing.Size(187, 24);
            this.cmbVeritabaniSec.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 454);
            this.tabControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(507, 454);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemSoft Veritabanı Yazılımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVeritabaniSec;
        private System.Windows.Forms.Button btnTabloOlustur;
        private System.Windows.Forms.Button btnTabloGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVeritabaniAdi;
        private System.Windows.Forms.Button btnVeritabaniOlustur;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

