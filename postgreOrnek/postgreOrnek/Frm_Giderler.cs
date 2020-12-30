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
    public partial class Frm_Giderler : Form
    {
        public Frm_Giderler()
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
            cmbAy.Text = "";
            cmbYil.Text = "";
            txtElektrik.Text = "";
            txtSu.Text = "";
            txtDogalgaz.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtEkstra.Text = "";
            rtbNot.Text = "";
        }

        // giderleri datagrie getirmek için gerekli meteod
        private void _giderlerGetir()
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_giderler order by giderid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        //gider eklemek eklemek için metod
        private void _giderEkle()
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_giderler (giderid,internet,maaslar,ekstra,elektrik,su,dogalgaz,ay,yil,notlar) values (@id,@int,@maas,@ekstra,@elekt,@su,@gaz,@ay,@yil,@not)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@int", double.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@maas", double.Parse(txtMaaslar.Text));
            command.Parameters.AddWithValue("@ekstra", double.Parse(txtEkstra.Text));
            command.Parameters.AddWithValue("@elekt", double.Parse(txtElektrik.Text));
            command.Parameters.AddWithValue("@su", double.Parse(txtSu.Text));
            command.Parameters.AddWithValue("@gaz", double.Parse(txtDogalgaz.Text));
            command.Parameters.AddWithValue("@ay", cmbAy.Text);
            command.Parameters.AddWithValue("@yil", cmbYil.Text);
            command.Parameters.AddWithValue("@not", rtbNot.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Giderlerin verileri başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //gider verilerini silmek için metod
        private void _giderSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Gider bilgilerini silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SilinsinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_giderler where giderid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle();
                _giderlerGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Giderleri silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        // gider verilerini güncellemek için gerekli metod
        private void _giderGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Giderlerin bilgilerini güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (GuncellensinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_giderler set internet=@int,maaslar=@maas,ekstra=@ekstra,elektrik=@elekt,su=@su,dogalgaz=@gaz,ay=@ay,yil=@yil,notlar=@not where giderid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@int", double.Parse(txtInternet.Text));
                command.Parameters.AddWithValue("@maas", double.Parse(txtMaaslar.Text));
                command.Parameters.AddWithValue("@ekstra", double.Parse(txtEkstra.Text));
                command.Parameters.AddWithValue("@elekt", double.Parse(txtElektrik.Text));
                command.Parameters.AddWithValue("@su", double.Parse(txtSu.Text));
                command.Parameters.AddWithValue("@gaz", double.Parse(txtDogalgaz.Text));
                command.Parameters.AddWithValue("@ay", cmbAy.Text);
                command.Parameters.AddWithValue("@yil", cmbYil.Text);
                command.Parameters.AddWithValue("@not", rtbNot.Text);
                _command(command);
                _temizle();
                _giderlerGetir();
            }
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Gider bilgilerini güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle();
            }
        }

        private void Frm_Giderler_Load(object sender, EventArgs e)
        {
            _giderlerGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _giderEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _giderSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _giderGuncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbAy.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbYil.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtElektrik.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDogalgaz.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtInternet.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMaaslar.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtEkstra.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            rtbNot.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
    }
}
