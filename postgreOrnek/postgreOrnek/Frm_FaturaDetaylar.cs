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
    public partial class Frm_FaturaDetaylar : Form
    {
        public Frm_FaturaDetaylar()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        public string id; //Frm_faturalar tablosundan hangi faturaya ait detayları getiriceğimizi belirtmek için public değişken tanımladık.

        // faturaya ait detayları datagride cekmek için metod
        private void _detaylarGetir()
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_faturadetay where faturaid='" + id + "'", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Frm_FaturaDetaylar_Load(object sender, EventArgs e)
        {
            _detaylarGetir();
        }
    }
}
