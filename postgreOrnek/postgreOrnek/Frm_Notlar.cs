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
    public partial class Frm_Notlar : Form
    {
        public Frm_Notlar()
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
            mtbTarih.Text = "";
            mtbSaat.Text = "";
            txtBaslik.Text = "";
            txtOlusturan.Text = "";
            txtKime.Text = "";
            rtbMesaj.Text = "";
        }

        // mesajları datagride getirmesi için metod
        private void _mesajlarGetir()
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_notlar order by id", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        //mesaj eklemek için metod
        private void _mesajEkle()
        {
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_notlar (id,tarih,saat,baslik,olusturan,kime,icerik) values (@id,@tarih,@saat,@baslik,@olusturan,@kime,@icerik)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@tarih", mtbTarih.Text);
            command.Parameters.AddWithValue("@saat", mtbSaat.Text);
            command.Parameters.AddWithValue("@baslik", txtBaslik.Text);
            command.Parameters.AddWithValue("@olusturan", txtOlusturan.Text);
            command.Parameters.AddWithValue("@kime", txtKime.Text);
            command.Parameters.AddWithValue("@icerik", rtbMesaj.Text);
            _command(command);
            MessageBox.Show("Mesajınız başarıyla yollandı.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mesajlarGetir();
        }

        //mesaj silmek için metod
        private void _mesajSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Mesajı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SilinsinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_notlar where id=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _mesajlarGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Mesaj silme işlemi İptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }

        }

        //mesaj güncellemek için gerekli metod
        private void _mesajGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Yayınlanan mesajı güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (GuncellensinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_notlar set tarih=@tarih,saat=@saat,baslik=@baslik,olusturan=@olusturan,kime=@kime,icerik=@icerik where id=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@tarih", mtbTarih.Text);
                command.Parameters.AddWithValue("@saat", mtbSaat.Text);
                command.Parameters.AddWithValue("@baslik", txtBaslik.Text);
                command.Parameters.AddWithValue("@olusturan", txtOlusturan.Text);
                command.Parameters.AddWithValue("@kime", txtKime.Text);
                command.Parameters.AddWithValue("@icerik", rtbMesaj.Text);
                _command(command);
                _temizle();
                _mesajlarGetir();
            }
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Mesajı güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        private void Frm_Notlar_Load(object sender, EventArgs e)
        {
            _mesajlarGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _mesajEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _mesajSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _mesajGuncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            mtbTarih.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            mtbSaat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBaslik.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOlusturan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtKime.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            rtbMesaj.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }


    }
}
