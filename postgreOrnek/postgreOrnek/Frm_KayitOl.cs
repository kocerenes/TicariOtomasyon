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
    public partial class Frm_KayitOl : Form
    {
        public Frm_KayitOl()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        private void _kayitOl()
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_admin (kullaniciad,sifre) values (@kAd,@sifre)", connection);
            command.Parameters.AddWithValue("@kAd", txtKullaniciAd.Text);
            command.Parameters.AddWithValue("@sifre", txtSifre.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            _kayitOl();
        }
    }
}
