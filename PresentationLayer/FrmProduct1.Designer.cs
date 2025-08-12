namespace PresentationLayer
{
    partial class FrmCategory1
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
            this.btnIdGetir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.radioPassive = new System.Windows.Forms.RadioButton();
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnListeleKategorili = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIdGetir
            // 
            this.btnIdGetir.Location = new System.Drawing.Point(180, 529);
            this.btnIdGetir.Name = "btnIdGetir";
            this.btnIdGetir.Size = new System.Drawing.Size(102, 28);
            this.btnIdGetir.TabIndex = 25;
            this.btnIdGetir.Text = "Id\'den Getir";
            this.btnIdGetir.UseVisualStyleBackColor = true;
            this.btnIdGetir.Click += new System.EventHandler(this.btnIdGetir_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(180, 495);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 28);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(86, 529);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 28);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(86, 495);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 28);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // radioPassive
            // 
            this.radioPassive.AutoSize = true;
            this.radioPassive.Location = new System.Drawing.Point(208, 420);
            this.radioPassive.Name = "radioPassive";
            this.radioPassive.Size = new System.Drawing.Size(62, 24);
            this.radioPassive.TabIndex = 21;
            this.radioPassive.TabStop = true;
            this.radioPassive.Text = "Pasif";
            this.radioPassive.UseVisualStyleBackColor = true;
            // 
            // radioActive
            // 
            this.radioActive.AutoSize = true;
            this.radioActive.Location = new System.Drawing.Point(143, 420);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(59, 24);
            this.radioActive.TabIndex = 20;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "Aktif";
            this.radioActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kategori Durum";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(129, 112);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(110, 26);
            this.txtAd.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 363);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(86, 461);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(88, 28);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 26);
            this.txtId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Id";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(129, 151);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(110, 26);
            this.txtUrunStok.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ürün Stok";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(129, 197);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(110, 26);
            this.txtUrunFiyat.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Fiyat";
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(17, 298);
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(253, 105);
            this.txtUrunAciklama.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ürün Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(129, 235);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(131, 28);
            this.cmbKategori.TabIndex = 33;
            // 
            // btnListeleKategorili
            // 
            this.btnListeleKategorili.Location = new System.Drawing.Point(180, 461);
            this.btnListeleKategorili.Name = "btnListeleKategorili";
            this.btnListeleKategorili.Size = new System.Drawing.Size(88, 28);
            this.btnListeleKategorili.TabIndex = 34;
            this.btnListeleKategorili.Text = "Listele K";
            this.btnListeleKategorili.UseVisualStyleBackColor = true;
            this.btnListeleKategorili.Click += new System.EventHandler(this.btnListeleKategorili_Click);
            // 
            // FrmCategory1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.btnListeleKategorili);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdGetir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.radioPassive);
            this.Controls.Add(this.radioActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCategory1";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmCategory1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdGetir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton radioPassive;
        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnListeleKategorili;
    }
}