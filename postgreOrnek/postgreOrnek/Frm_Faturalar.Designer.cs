namespace postgreOrnek
{
    partial class Frm_Faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Faturalar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbSaat = new System.Windows.Forms.MaskedTextBox();
            this.mtbTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnFaturaGuncelle = new System.Windows.Forms.Button();
            this.btnFaturaSil = new System.Windows.Forms.Button();
            this.btnFaturaEkle = new System.Windows.Forms.Button();
            this.txtTeslimEden = new System.Windows.Forms.TextBox();
            this.txtTeslimAlan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtSirano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblM = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFirmaId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMHareket = new System.Windows.Forms.TextBox();
            this.txtFHareketId = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDetayId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnDetayGuncelle = new System.Windows.Forms.Button();
            this.btnDetaySil = new System.Windows.Forms.Button();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.txtFaturaId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbSaat);
            this.groupBox1.Controls.Add(this.mtbTarih);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnFaturaGuncelle);
            this.groupBox1.Controls.Add(this.btnFaturaSil);
            this.groupBox1.Controls.Add(this.btnFaturaEkle);
            this.groupBox1.Controls.Add(this.txtTeslimEden);
            this.groupBox1.Controls.Add(this.txtTeslimAlan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAlici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSeri);
            this.groupBox1.Controls.Add(this.txtSirano);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Oluşturma";
            // 
            // mtbSaat
            // 
            this.mtbSaat.Location = new System.Drawing.Point(178, 177);
            this.mtbSaat.Mask = "00:00";
            this.mtbSaat.Name = "mtbSaat";
            this.mtbSaat.Size = new System.Drawing.Size(176, 30);
            this.mtbSaat.TabIndex = 4;
            this.mtbSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTarih
            // 
            this.mtbTarih.Location = new System.Drawing.Point(178, 141);
            this.mtbTarih.Mask = "00/00/0000";
            this.mtbTarih.Name = "mtbTarih";
            this.mtbTarih.Size = new System.Drawing.Size(176, 30);
            this.mtbTarih.TabIndex = 3;
            this.mtbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(504, 59);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(54, 42);
            this.btnTemizle.TabIndex = 66;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnFaturaGuncelle
            // 
            this.btnFaturaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnFaturaGuncelle.Location = new System.Drawing.Point(373, 235);
            this.btnFaturaGuncelle.Name = "btnFaturaGuncelle";
            this.btnFaturaGuncelle.Size = new System.Drawing.Size(185, 44);
            this.btnFaturaGuncelle.TabIndex = 10;
            this.btnFaturaGuncelle.Text = "Güncelle";
            this.btnFaturaGuncelle.UseVisualStyleBackColor = true;
            this.btnFaturaGuncelle.Click += new System.EventHandler(this.btnFaturaGuncelle_Click);
            // 
            // btnFaturaSil
            // 
            this.btnFaturaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaSil.ForeColor = System.Drawing.Color.White;
            this.btnFaturaSil.Location = new System.Drawing.Point(373, 171);
            this.btnFaturaSil.Name = "btnFaturaSil";
            this.btnFaturaSil.Size = new System.Drawing.Size(185, 44);
            this.btnFaturaSil.TabIndex = 9;
            this.btnFaturaSil.Text = "Sil";
            this.btnFaturaSil.UseVisualStyleBackColor = true;
            this.btnFaturaSil.Click += new System.EventHandler(this.btnFaturaSil_Click);
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaEkle.ForeColor = System.Drawing.Color.White;
            this.btnFaturaEkle.Location = new System.Drawing.Point(373, 107);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(185, 44);
            this.btnFaturaEkle.TabIndex = 8;
            this.btnFaturaEkle.Text = "Ekle";
            this.btnFaturaEkle.UseVisualStyleBackColor = true;
            this.btnFaturaEkle.Click += new System.EventHandler(this.btnFaturaEkle_Click);
            // 
            // txtTeslimEden
            // 
            this.txtTeslimEden.Location = new System.Drawing.Point(178, 251);
            this.txtTeslimEden.Name = "txtTeslimEden";
            this.txtTeslimEden.Size = new System.Drawing.Size(176, 30);
            this.txtTeslimEden.TabIndex = 6;
            // 
            // txtTeslimAlan
            // 
            this.txtTeslimAlan.Location = new System.Drawing.Point(178, 289);
            this.txtTeslimAlan.Name = "txtTeslimAlan";
            this.txtTeslimAlan.Size = new System.Drawing.Size(176, 30);
            this.txtTeslimAlan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "Teslim alan :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Teslim eden :";
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(178, 215);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(176, 30);
            this.txtAlici.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Alıcı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(113, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Saat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tarih :";
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(178, 66);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(176, 30);
            this.txtSeri.TabIndex = 1;
            // 
            // txtSirano
            // 
            this.txtSirano.Location = new System.Drawing.Point(178, 104);
            this.txtSirano.Name = "txtSirano";
            this.txtSirano.Size = new System.Drawing.Size(176, 30);
            this.txtSirano.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sıra no :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Seri no :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(178, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 30);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblM);
            this.groupBox2.Controls.Add(this.lblF);
            this.groupBox2.Controls.Add(this.txtPersonelId);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtFirmaId);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtMusteriId);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtMHareket);
            this.groupBox2.Controls.Add(this.txtFHareketId);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.cmbCari);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDetayId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnTemizle2);
            this.groupBox2.Controls.Add(this.btnDetayGuncelle);
            this.groupBox2.Controls.Add(this.btnDetaySil);
            this.groupBox2.Controls.Add(this.btnDetayEkle);
            this.groupBox2.Controls.Add(this.txtFaturaId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtUrunId);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(584, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 346);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Detayları";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.ForeColor = System.Drawing.Color.White;
            this.lblM.Location = new System.Drawing.Point(245, 283);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(29, 24);
            this.lblM.TabIndex = 83;
            this.lblM.Text = "M";
            this.lblM.Visible = false;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.ForeColor = System.Drawing.Color.White;
            this.lblF.Location = new System.Drawing.Point(187, 283);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(22, 24);
            this.lblF.TabIndex = 82;
            this.lblF.Text = "F";
            this.lblF.Visible = false;
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(136, 212);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(176, 30);
            this.txtPersonelId.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(41, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 24);
            this.label19.TabIndex = 80;
            this.label19.Text = "Personel :";
            // 
            // txtFirmaId
            // 
            this.txtFirmaId.Location = new System.Drawing.Point(433, 72);
            this.txtFirmaId.Name = "txtFirmaId";
            this.txtFirmaId.Size = new System.Drawing.Size(156, 30);
            this.txtFirmaId.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(354, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 24);
            this.label18.TabIndex = 79;
            this.label18.Text = "Firma :";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(433, 36);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(156, 30);
            this.txtMusteriId.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(337, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 24);
            this.label17.TabIndex = 77;
            this.label17.Text = "Müşteri :";
            // 
            // txtMHareket
            // 
            this.txtMHareket.Location = new System.Drawing.Point(233, 310);
            this.txtMHareket.Name = "txtMHareket";
            this.txtMHareket.Size = new System.Drawing.Size(51, 30);
            this.txtMHareket.TabIndex = 75;
            this.txtMHareket.Visible = false;
            // 
            // txtFHareketId
            // 
            this.txtFHareketId.Location = new System.Drawing.Point(176, 310);
            this.txtFHareketId.Name = "txtFHareketId";
            this.txtFHareketId.Size = new System.Drawing.Size(51, 30);
            this.txtFHareketId.TabIndex = 74;
            this.txtFHareketId.Visible = false;
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(233, 64);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(79, 34);
            this.btnAra.TabIndex = 73;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbCari
            // 
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "Firma",
            "Müşteri"});
            this.cmbCari.Location = new System.Drawing.Point(136, 248);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(176, 32);
            this.cmbCari.TabIndex = 72;
            this.cmbCari.Tag = "";
            this.cmbCari.SelectedIndexChanged += new System.EventHandler(this.cmbCari_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 71;
            this.label10.Text = "Cari tür :";
            // 
            // txtDetayId
            // 
            this.txtDetayId.Location = new System.Drawing.Point(136, 30);
            this.txtDetayId.Name = "txtDetayId";
            this.txtDetayId.Size = new System.Drawing.Size(176, 30);
            this.txtDetayId.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(87, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "ID :";
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle2.BackgroundImage")));
            this.btnTemizle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle2.Location = new System.Drawing.Point(535, 154);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(54, 42);
            this.btnTemizle2.TabIndex = 67;
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // btnDetayGuncelle
            // 
            this.btnDetayGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetayGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDetayGuncelle.Location = new System.Drawing.Point(438, 279);
            this.btnDetayGuncelle.Name = "btnDetayGuncelle";
            this.btnDetayGuncelle.Size = new System.Drawing.Size(151, 31);
            this.btnDetayGuncelle.TabIndex = 65;
            this.btnDetayGuncelle.Text = "Güncelle";
            this.btnDetayGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnDetaySil
            // 
            this.btnDetaySil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetaySil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaySil.ForeColor = System.Drawing.Color.White;
            this.btnDetaySil.Location = new System.Drawing.Point(438, 242);
            this.btnDetaySil.Name = "btnDetaySil";
            this.btnDetaySil.Size = new System.Drawing.Size(151, 31);
            this.btnDetaySil.TabIndex = 64;
            this.btnDetaySil.Text = "Sil";
            this.btnDetaySil.UseVisualStyleBackColor = true;
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetayEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayEkle.ForeColor = System.Drawing.Color.White;
            this.btnDetayEkle.Location = new System.Drawing.Point(438, 202);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(151, 31);
            this.btnDetayEkle.TabIndex = 63;
            this.btnDetayEkle.Text = "Ekle";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            this.btnDetayEkle.Click += new System.EventHandler(this.btnDetayEkle_Click);
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(433, 107);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.Size = new System.Drawing.Size(156, 30);
            this.txtFaturaId.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(329, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 58;
            this.label11.Text = "Fatura Id :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(136, 177);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(176, 30);
            this.txtFiyat.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(65, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Fiyat :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(136, 103);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(176, 30);
            this.txtUrunAd.TabIndex = 48;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(136, 141);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(176, 30);
            this.txtMiktar.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(49, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 52;
            this.label14.Text = "Miktar :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(37, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 24);
            this.label15.TabIndex = 51;
            this.label15.Text = "Ürün ad :";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(136, 66);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(91, 30);
            this.txtUrunId.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(39, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 24);
            this.label16.TabIndex = 50;
            this.label16.Text = "Ürün Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 232);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // Frm_Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1191, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Faturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturalar Paneli";
            this.Load += new System.EventHandler(this.Frm_Faturalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTeslimEden;
        private System.Windows.Forms.TextBox txtTeslimAlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtSirano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaturaGuncelle;
        private System.Windows.Forms.Button btnFaturaSil;
        private System.Windows.Forms.Button btnFaturaEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDetayGuncelle;
        private System.Windows.Forms.Button btnDetaySil;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.MaskedTextBox mtbSaat;
        private System.Windows.Forms.MaskedTextBox mtbTarih;
        private System.Windows.Forms.TextBox txtDetayId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtMHareket;
        private System.Windows.Forms.TextBox txtFHareketId;
        private System.Windows.Forms.TextBox txtFirmaId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}