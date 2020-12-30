namespace postgreOrnek
{
    partial class Frm_Giderler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtDogalgaz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaaslar = new System.Windows.Forms.TextBox();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbNot = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 569);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Yıl :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ay :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(911, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 30);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID :";
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(911, 158);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(176, 30);
            this.txtSu.TabIndex = 4;
            // 
            // txtDogalgaz
            // 
            this.txtDogalgaz.Location = new System.Drawing.Point(911, 196);
            this.txtDogalgaz.Name = "txtDogalgaz";
            this.txtDogalgaz.Size = new System.Drawing.Size(176, 30);
            this.txtDogalgaz.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(803, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Doğalgaz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Su :";
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(911, 121);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(176, 30);
            this.txtElektrik.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Elektrik :";
            // 
            // txtMaaslar
            // 
            this.txtMaaslar.Location = new System.Drawing.Point(911, 269);
            this.txtMaaslar.Name = "txtMaaslar";
            this.txtMaaslar.Size = new System.Drawing.Size(176, 30);
            this.txtMaaslar.TabIndex = 7;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(911, 307);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(176, 30);
            this.txtEkstra.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ekstra :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Maaşlar :";
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(911, 232);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(176, 30);
            this.txtInternet.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(812, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "internet :";
            // 
            // rtbNot
            // 
            this.rtbNot.Location = new System.Drawing.Point(911, 343);
            this.rtbNot.Name = "rtbNot";
            this.rtbNot.Size = new System.Drawing.Size(176, 124);
            this.rtbNot.TabIndex = 9;
            this.rtbNot.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(851, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 66;
            this.label10.Text = "Not :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(922, 517);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(159, 39);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(983, 473);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 38);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(850, 473);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 38);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbAy
            // 
            this.cmbAy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Location = new System.Drawing.Point(911, 46);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(176, 32);
            this.cmbAy.TabIndex = 1;
            // 
            // cmbYil
            // 
            this.cmbYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2020"});
            this.cmbYil.Location = new System.Drawing.Point(911, 85);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(176, 32);
            this.cmbYil.TabIndex = 2;
            // 
            // Frm_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1138, 569);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rtbNot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaaslar);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInternet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSu);
            this.Controls.Add(this.txtDogalgaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtElektrik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Giderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler paneli";
            this.Load += new System.EventHandler(this.Frm_Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtDogalgaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaaslar;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbNot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
    }
}