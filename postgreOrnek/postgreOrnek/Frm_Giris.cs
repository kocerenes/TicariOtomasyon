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
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localhost; port = 5432; DataBase = dbproje; user ID = postgres; password = 24042000");

        private void _giris()
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from tbl_admin where kullaniciad=@kAd and sifre=@sifre", connection);
            command.Parameters.AddWithValue("@kAd", txtKullaniciAd.Text);
            command.Parameters.AddWithValue("@sifre", txtSifre.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                Frm_AnaSayfa anaSayfa = new Frm_AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış bilgi girdiniz.");
            }
            connection.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            _giris();
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_KayitOl frm_Kayit = new Frm_KayitOl();
            frm_Kayit.Show();
        }
    }
}
