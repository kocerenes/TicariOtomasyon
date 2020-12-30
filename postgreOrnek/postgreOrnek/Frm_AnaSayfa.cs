using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace postgreOrnek
{
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        Frm_Urunler frm_urunler;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ürünler paneli arka arkaya açılamasın diye böyle bir şart bloğu yazdık.
            // 1 kere açıldıktan sonra program sonlanmadığı taktirde yeniden açamıyoduk buna çözüm olarak IsDisposed terimini kullandık.
            if (frm_urunler == null || frm_urunler.IsDisposed)
            {
                frm_urunler = new Frm_Urunler();
                frm_urunler.Show();
            }
        }

        Frm_Musteriler frm_musteriler;
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_musteriler == null || frm_musteriler.IsDisposed)
            {
                frm_musteriler = new Frm_Musteriler();
                frm_musteriler.Show();
            }
        }

        Frm_Firmalar frm_firmalar;
        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_firmalar==null || frm_firmalar.IsDisposed)
            {
                frm_firmalar = new Frm_Firmalar();
                frm_firmalar.Show();
            }
        }

        Frm_Personeller frm_personeller;
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_personeller==null || frm_personeller.IsDisposed)
            {
                frm_personeller = new Frm_Personeller();
                frm_personeller.Show();
            }
        }

        Frm_Giderler frm_giderler;
        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_giderler==null || frm_giderler.IsDisposed)
            {
                frm_giderler = new Frm_Giderler();
                frm_giderler.Show();
            }
        }

        Frm_Notlar frm_notlar;
        private void notlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_notlar==null || frm_notlar.IsDisposed)
            {
                frm_notlar = new Frm_Notlar();
                frm_notlar.Show();
            }
        }

        Frm_Faturalar frm_faturalar;
        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_faturalar==null || frm_faturalar.IsDisposed)
            {
                frm_faturalar = new Frm_Faturalar();
                frm_faturalar.Show();
            }
        }

        Frm_MusteriHareket frm_musterihareket;
        private void müşterilerinHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_musterihareket==null || frm_musterihareket.IsDisposed)
            {
                frm_musterihareket = new Frm_MusteriHareket();
                frm_musterihareket.Show();
            }
        }

        Frm_FirmaHareket frm_firmahareket;
        private void firmalarınHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_firmahareket==null || frm_firmahareket.IsDisposed)
            {
                frm_firmahareket = new Frm_FirmaHareket();
                frm_firmahareket.Show();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        // son eklenen notları tarihe göre listeleme işlemi için metod
        public void _notlariGetir()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select olusturan as oluşturan,baslik as başlık,icerik as içerik,tarih,saat from tbl_notlar where kime='Herkes'", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvNotlar.DataSource = dataTable;
        }

        // personellerin iletişim bilgilerini getirmek için metod
        private void _personelRehber()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select ad,soyad,mail,telefonno from tbl_personeller order by personelid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvRehber.DataSource = dataTable;
        }

        // ürünleri ve stoklarının verilerini getirmek için metod
        private void _stokgetir()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select urunad as ürün_adı,marka,adet from tbl_urunler order by adet ASC", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvStok.DataSource = dataTable;
        }

        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            _notlariGetir();
            _personelRehber();
            _stokgetir();

            // btnYenile adlı butonun işlevini belirtmesi için mouseu üzerine götürdüğümüzde bilgilerindirme yayınladık.
            ToolTip yenile = new ToolTip();
            yenile.ToolTipIcon = ToolTipIcon.Info;
            yenile.IsBalloon = true;
            yenile.SetToolTip(btnYenile, "Sayfayı yenile");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            _notlariGetir();
            _personelRehber();
            _stokgetir();
        }
    }
}
