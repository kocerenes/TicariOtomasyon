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
    public partial class Frm_Yetkili : Form
    {
        public Frm_Yetkili()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        private void Frm_Yetkili_Load(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select firmayetkiliid as id,adsoyad,yetkilistatu,yetkilitc from tbl_firmayetkili order by firmayetkiliid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
