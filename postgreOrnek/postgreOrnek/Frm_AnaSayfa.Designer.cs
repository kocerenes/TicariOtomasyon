namespace postgreOrnek
{
    partial class Frm_AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hareketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerinHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarınHareketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRehber = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNotlar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRehber)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.faturalarToolStripMenuItem,
            this.hareketlerToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            this.müşterilerToolStripMenuItem.Click += new System.EventHandler(this.müşterilerToolStripMenuItem_Click);
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(85, 27);
            this.firmalarToolStripMenuItem.Text = "Firmalar";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            this.giderlerToolStripMenuItem.Click += new System.EventHandler(this.giderlerToolStripMenuItem_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.notlarToolStripMenuItem.Text = "Notlar";
            this.notlarToolStripMenuItem.Click += new System.EventHandler(this.notlarToolStripMenuItem_Click);
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.faturalarToolStripMenuItem.Text = "Faturalar";
            this.faturalarToolStripMenuItem.Click += new System.EventHandler(this.faturalarToolStripMenuItem_Click);
            // 
            // hareketlerToolStripMenuItem
            // 
            this.hareketlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerinHareketleriToolStripMenuItem,
            this.firmalarınHareketleriToolStripMenuItem});
            this.hareketlerToolStripMenuItem.Name = "hareketlerToolStripMenuItem";
            this.hareketlerToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.hareketlerToolStripMenuItem.Text = "Hareketler";
            // 
            // müşterilerinHareketleriToolStripMenuItem
            // 
            this.müşterilerinHareketleriToolStripMenuItem.Name = "müşterilerinHareketleriToolStripMenuItem";
            this.müşterilerinHareketleriToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.müşterilerinHareketleriToolStripMenuItem.Text = "Müşterilerin hareketleri";
            this.müşterilerinHareketleriToolStripMenuItem.Click += new System.EventHandler(this.müşterilerinHareketleriToolStripMenuItem_Click);
            // 
            // firmalarınHareketleriToolStripMenuItem
            // 
            this.firmalarınHareketleriToolStripMenuItem.Name = "firmalarınHareketleriToolStripMenuItem";
            this.firmalarınHareketleriToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.firmalarınHareketleriToolStripMenuItem.Text = "Firmaların hareketleri";
            this.firmalarınHareketleriToolStripMenuItem.Click += new System.EventHandler(this.firmalarınHareketleriToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(58, 27);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRehber);
            this.groupBox1.Location = new System.Drawing.Point(0, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Rehber";
            // 
            // dgvRehber
            // 
            this.dgvRehber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRehber.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRehber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRehber.Location = new System.Drawing.Point(3, 26);
            this.dgvRehber.Name = "dgvRehber";
            this.dgvRehber.RowHeadersWidth = 51;
            this.dgvRehber.RowTemplate.Height = 24;
            this.dgvRehber.Size = new System.Drawing.Size(453, 185);
            this.dgvRehber.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStok);
            this.groupBox2.Location = new System.Drawing.Point(504, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stoklar";
            // 
            // dgvStok
            // 
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStok.Location = new System.Drawing.Point(3, 26);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.RowHeadersWidth = 51;
            this.dgvStok.RowTemplate.Height = 24;
            this.dgvStok.Size = new System.Drawing.Size(453, 185);
            this.dgvStok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNotlar);
            this.groupBox3.Location = new System.Drawing.Point(0, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 150);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Son eklenen notlar";
            // 
            // dgvNotlar
            // 
            this.dgvNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotlar.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotlar.Location = new System.Drawing.Point(3, 26);
            this.dgvNotlar.Name = "dgvNotlar";
            this.dgvNotlar.RowHeadersWidth = 51;
            this.dgvNotlar.RowTemplate.Height = 24;
            this.dgvNotlar.Size = new System.Drawing.Size(776, 121);
            this.dgvNotlar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(783, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 100);
            this.panel1.TabIndex = 6;
            // 
            // btnYenile
            // 
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Location = new System.Drawing.Point(898, 52);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(53, 42);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Tag = "";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(964, 445);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Frm_AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRehber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hareketlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerinHareketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarınHareketleriToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvRehber;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNotlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnYenile;
    }
}