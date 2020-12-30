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
    public partial class Frm_Personeller : Form
    {
        public Frm_Personeller()
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
            mtbTc.Text = "";
            mtbTel.Text = "";
            txtGorev.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
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
        }

        // seçtiğim ile göre uygun olan ilçeleri combobaxımıza eklemek için gerekli metod
        private void _ilcelerGetir()
        {
            cmbIlce.Items.Clear(); // her il seçiminden sonra ilçe comboboxımızı temizlemezsek seçtiğimiz her şehrin ilçesi birbirine karışır.

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select ilce from tbl_ilceler where sehir=@sehir", connection);
            command.Parameters.AddWithValue("@sehir", cmbIl.SelectedIndex + 1); // illerin indexi 0 dan başladığı için +1 ekledik
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Items.Add(dataReader[0].ToString()) ;
            }
            connection.Close();
        }

        // personel tablomuzu datagride çekmek için gerekli metod
        private void _personellerGetir()
        {
            //NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select personelid,ad,soyad,tcno,tbl_gorevler.gorevisim,telefonno,mail,il,ilce,adres from tbl_personeller inner join tbl_gorevler on tbl_personeller.gorev=tbl_gorevler.gorevid order by personelid", connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from personellerigetir()", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        // personel ekleme işlemi için metod
        private void _personelEkle()
        {
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_personeller (personelid,ad,soyad,tcno,gorev,telefonno,mail,il,ilce,adres) values (@id,@ad,@soyad,@tc,@gorev,@tel,@mail,@il,@ilce,@adres)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@tc", mtbTc.Text);
            command.Parameters.AddWithValue("@gorev", int.Parse(txtGorev.Text));
            command.Parameters.AddWithValue("@tel", mtbTel.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.Parameters.AddWithValue("@il", cmbIl.Text);
            command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            command.Parameters.AddWithValue("@adres", rtbAdres.Text);
            _command(command);
            MessageBox.Show("Personel verileri başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _personellerGetir();
        }

        //personel silme işlemi için metod
        private void _personelSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Personeli silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SilinsinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_personeller where personelid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _personellerGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Personel silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        // personel bilgilerini güncllemek için metod
        private void _personelGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Personel bilgilerini güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (GuncellensinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_personeller set ad=@ad,soyad=@soyad,tcno=@tc,gorev=@gorev,telefonno=@tel,mail=@mail,il=@il,ilce=@ilce,adres=@adres where personelid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@ad", txtAd.Text);
                command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                command.Parameters.AddWithValue("@tc", mtbTc.Text);
                command.Parameters.AddWithValue("@gorev", int.Parse(txtGorev.Text));
                command.Parameters.AddWithValue("@tel", mtbTel.Text);
                command.Parameters.AddWithValue("@mail", txtMail.Text);
                command.Parameters.AddWithValue("@il", cmbIl.Text);
                command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                command.Parameters.AddWithValue("@adres", rtbAdres.Text);
                _command(command);
                _temizle();
                _personellerGetir();
            }
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Personel bilgilerini güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        private void Frm_Personeller_Load(object sender, EventArgs e)
        {
            _ilGetir();
            _personellerGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _personelEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _personelSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _personelGuncelle();
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
            mtbTc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGorev.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mtbTel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            rtbAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
    }
}
