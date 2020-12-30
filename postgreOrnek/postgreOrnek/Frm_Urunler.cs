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
    public partial class Frm_Urunler : Form
    {
        public Frm_Urunler()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        // bağlantı açıp kapayıp execute etme işlemlerini tek bir metod da topladık
        private void _command(NpgsqlCommand command)
        {
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        //araçların içini boşaltmak için metod
        private void _temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtYil.Text = "";
            nudAdet.Value = 0;
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            rtbDetay.Text = "";
        }


        // ürünler tablomuzu datagridview e çekmek için yazdığımız metod.
        private void _urunleriGetir()
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_urunler order by urunid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        // ürünler tablomuza veri girmek için yazdığımız metod.
        private void _urunEkle()
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_urunler (urunid,urunad,marka,yil,adet,alisfiyat,satisfiyat,detay) values (@id,@ad,@marka,@yil,@adet,@alisfiyat,@satisfiyat,@detay)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@yil", txtYil.Text);
            command.Parameters.AddWithValue("@adet", int.Parse(nudAdet.Text));
            command.Parameters.AddWithValue("@alisfiyat", decimal.Parse(txtAlisFiyat.Text));
            command.Parameters.AddWithValue("@satisfiyat", decimal.Parse(txtSatisFiyat.Text));
            command.Parameters.AddWithValue("@detay", rtbDetay.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün ekleme işlemi başarıyla gerçekleşmiştir.");
            _urunleriGetir();
        }


        private void _urunSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //evet cevabı için gerekli şart bloğu
            if (SilinsinMi == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_urunler where urunid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _urunleriGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Ürün silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        // ürün bilgilerini güncellemek için gerekli metod
        private void _urunGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Ürünü güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //evet cevabı için gerekli şart bloğu
            if (GuncellensinMi == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_urunler set urunad=@ad, marka=@marka ,yil=@yil , adet=@adet , alisfiyat=@alis , satisfiyat=@satis , detay=@detay where urunid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@ad", txtAd.Text);
                command.Parameters.AddWithValue("@marka", txtMarka.Text);
                command.Parameters.AddWithValue("@yil", txtYil.Text);
                command.Parameters.AddWithValue("@adet", int.Parse(nudAdet.Text));
                command.Parameters.AddWithValue("@alis", decimal.Parse(txtAlisFiyat.Text));
                command.Parameters.AddWithValue("@satis", decimal.Parse(txtSatisFiyat.Text));
                command.Parameters.AddWithValue("@detay", rtbDetay.Text);
                _command(command);
                _temizle();
                _urunleriGetir();
            }
            // hayır cevabı için gerekli şart bloğu
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Ürün güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }


        private void Frm_Urunler_Load(object sender, EventArgs e)
        {
            _urunleriGetir(); // ürünleri datagride getirmesi için metodumuzu çağırdık
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _urunEkle(); // ürün ekleme işlemi için metodumuzu çağırdık
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _urunSil(); // ürün silmek için metodumuzu çağırdık
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _urunGuncelle(); // ürünlerin bilgilerini güncellemesi için metodumuzu çağırdık
        }

        // datagriddeki bi satıra tıkladığımızda bilgilerin belirttiğimiz araçlara taşınmasını sağladık
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtYil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            nudAdet.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtAlisFiyat.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSatisFiyat.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            rtbDetay.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
