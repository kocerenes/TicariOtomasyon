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
    public partial class Frm_Musteriler : Form
    {
        public Frm_Musteriler()
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
            txtSoyad.Text = "";
            mtbTelefon.Text = "";
            mtbTc.Text = "";
            txtMail.Text = "";
            cmbIl.Text="";
            cmbIlce.Text="";
            rtbAdres.Text = "";
        }

        // iller tablomuzdaki verilerimizi combobaxımıza eklemek için gerekli metod
        private void _ilGetir()
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("select sehir from tbl_iller", connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Items.Add(dataReader[0]);
            }
            connection.Close();

            //NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select sehir from tbl_iller", connection);
            //DataTable dataTable = new DataTable();
            //cmbIl.ValueMember = "id";
            //cmbIl.DisplayMember = "sehir";
            //dataAdapter.Fill(dataTable);
            //cmbIl.DataSource = dataTable;
        }

        // seçtiğim ile göre uygun olan ilçeleri combobaxımıza eklemek için gerekli metod
        private void _ilcelerGetir()
        {
            cmbIlce.Items.Clear(); // her il seçiminden sonra ilçe comboboxımızı temizlemezsek seçtiğimiz her şehrin ilçesi birbirine karışır.

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select ilce from tbl_ilceler where sehir=@sehir", connection);
            command.Parameters.AddWithValue("@sehir", cmbIl.SelectedIndex+1); // illerin indexi 0 dan başladığı için +1 ekledik
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Items.Add(dataReader[0]);
            }
            connection.Close();
        }

        // müşteriler tablomuzu datagridview e çekmek için yazdığımız metod.
        private void _musterilerGetir()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_musteriler order by musteriid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        // müşteriler tablomuza veri eklemek için gerekli metod
        private void _musteriEkle()
        {
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_musteriler (musteriid,ad,soyad,telefon,tcno,mail,il,ilce,adres) values (@id,@ad,@soyad,@tel,@tc,@mail,@il,@ilce,@adres)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@tel", mtbTelefon.Text);
            command.Parameters.AddWithValue("@tc", mtbTc.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.Parameters.AddWithValue("@il", cmbIl.Text);
            command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            command.Parameters.AddWithValue("@adres", rtbAdres.Text);
            _command(command);
            MessageBox.Show("Müşteri verileri başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _musterilerGetir();
        }

        //müşteri silmek için gerekli metod
        private void _musteriSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Müşteriyi silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //evet cevabı için gerekli şart bloğu
            if (SilinsinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_musteriler where musteriid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _musterilerGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Müşteri silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        //müşteri bilgilerini güncellemek için gerekli metod
        private void _musteriGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Müşteri bilgilerini güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //evet cevabı için gerekli şart bloğu
            if (GuncellensinMi == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_musteriler set ad=@ad,soyad=@soyad,telefon=@tel,tcno=@tc,mail=@mail,il=@il,ilce=@ilce,adres=@adres where musteriid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@ad", txtAd.Text);
                command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                command.Parameters.AddWithValue("@tel", mtbTelefon.Text);
                command.Parameters.AddWithValue("@tc", mtbTc.Text);
                command.Parameters.AddWithValue("@mail", txtMail.Text);
                command.Parameters.AddWithValue("@il", cmbIl.Text);
                command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                command.Parameters.AddWithValue("@adres", rtbAdres.Text);
                _command(command);
                _temizle();
                _musterilerGetir();
            }
            if (GuncellensinMi == DialogResult.No)
            {
                MessageBox.Show("Müşteri bilgilerini güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        private void Frm_Musteriler_Load(object sender, EventArgs e)
        {
            _musterilerGetir();
            _ilGetir();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            _musteriEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _musteriSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _musteriGuncelle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Text = "";
            _ilcelerGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtbTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtbTc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            rtbAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
