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
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
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
            //cmbYetkili.Text = "";
            txtYetkili.Text = "";
            txtFirmaAd.Text = "";
            txtSektor.Text = "";
            mtbTelefon1.Text = "";
            mtbTelefon2.Text = "";
            txtMail.Text = "";
            mtbFax.Text = "";
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
                cmbIlce.Items.Add(dataReader[0]);
            }
            connection.Close();
        }

        //firma tablosunu datagridviewe taşımak için metod
        private void _firmalarGetir()
        {
            //NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select firmaid,tbl_firmayetkili.adsoyad,firmaad,sektor,telefon1,telefon2,mail,fax,il,ilce,adres from tbl_firmalar inner join tbl_firmayetkili on tbl_firmalar.yetkili=tbl_firmayetkili.firmayetkiliid order by firmaid", connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from firmalarigetir()", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        // firma ekleme işlemi için metod
        private void _firmaEkle()
        {
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_firmalar (firmaid,yetkili,firmaad,sektor,telefon1,telefon2,mail,fax,il,ilce,adres) values (@id,@yetkili,@ad,@sektor,@tel1,@tel2,@mail,@fax,@il,@ilce,@adres)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@yetkili",int.Parse(txtYetkili.Text));
            command.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
            command.Parameters.AddWithValue("@sektor", txtSektor.Text);
            command.Parameters.AddWithValue("@tel1", mtbTelefon1.Text);
            command.Parameters.AddWithValue("@tel2", mtbTelefon2.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.Parameters.AddWithValue("@fax", mtbFax.Text);
            command.Parameters.AddWithValue("@il", cmbIl.Text);
            command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            command.Parameters.AddWithValue("@adres", rtbAdres.Text);
            _command(command);
            MessageBox.Show("Firma verileri başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _firmalarGetir();
        }

        //firma silmek için metod
        private void _firmaSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Firmayı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SilinsinMi == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_firmalar where firmaid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _firmalarGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Firmayı silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        //firma bilgilerini güncellemek için metod
        private void _firmaGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Firma bilgilerini güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (GuncellensinMi == DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_firmalar set yetkili=@yetkili,firmaad=@ad,sektor=@sektor,telefon1=@tel1,telefon2=@tel2,mail=@mail,fax=@fax,il=@il,ilce=@ilce,adres=@adres where firmaid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@yetkili", int.Parse(txtYetkili.Text));
                command.Parameters.AddWithValue("@ad", txtFirmaAd.Text);
                command.Parameters.AddWithValue("@sektor", txtSektor.Text);
                command.Parameters.AddWithValue("@tel1", mtbTelefon1.Text);
                command.Parameters.AddWithValue("@tel2", mtbTelefon2.Text);
                command.Parameters.AddWithValue("@mail", txtMail.Text);
                command.Parameters.AddWithValue("@fax", mtbFax.Text);
                command.Parameters.AddWithValue("@il", cmbIl.Text);
                command.Parameters.AddWithValue("@ilce", cmbIlce.Text);
                command.Parameters.AddWithValue("@adres", rtbAdres.Text);
                _command(command);
                _temizle();
                _firmalarGetir();
            }
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Firma bilgilerini güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        private void Tbl_Firmalar_Load(object sender, EventArgs e)
        {
            _firmalarGetir();

            _ilGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _firmaEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _firmaSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _firmaGuncelle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ilcelerGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYetkili.Text = "";
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtYetkili.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFirmaAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSektor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtbTelefon1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mtbTelefon2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            mtbFax.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbIl.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            rtbAdres.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yetkili frm_yetkili = new Frm_Yetkili();
            frm_yetkili.Show();
        }
    }
}
