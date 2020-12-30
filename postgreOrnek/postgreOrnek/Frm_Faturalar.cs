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
    public partial class Frm_Faturalar : Form
    {
        public Frm_Faturalar()
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

        //fatura bilgi groupboxının içindeki araçların içini boşaltmak için metod
        private void _temizle1()
        {
            txtId.Text = "";
            txtSeri.Text = "";
            txtSirano.Text = "";
            mtbTarih.Text = "";
            mtbSaat.Text = "";
            txtAlici.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
        }

        //fatura detay groupboxının içindeki araçların içini boşaltmak için metod
        private void _temizle2()
        {
            txtDetayId.Text = "";
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtFaturaId.Text = "";
        }

        // fatura bilgilerini datagride çekmek için gerekli metod
        private void _faturaBilgiGetir()
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from tbl_faturabilgi order by faturabilgiid", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        //Fatura bilgi eklemek için metod 
        private void _faturaBilgiEkle()
        {
            NpgsqlCommand command = new NpgsqlCommand("Insert into tbl_faturabilgi (faturabilgiid,serino,sirano,tarih,saat,alici,teslimeden,teslimalan) values (@id,@seri,@sira,@tarih,@saat,@alici,@teslimeden,@teslimalan)", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            command.Parameters.AddWithValue("@seri", txtSeri.Text);
            command.Parameters.AddWithValue("@sira", txtSirano.Text);
            command.Parameters.AddWithValue("@tarih", mtbTarih.Text);
            command.Parameters.AddWithValue("@saat", mtbSaat.Text);
            command.Parameters.AddWithValue("@alici", txtAlici.Text);
            command.Parameters.AddWithValue("@teslimeden", txtTeslimEden.Text);
            command.Parameters.AddWithValue("@teslimalan", txtTeslimAlan.Text);
            _command(command);
            MessageBox.Show("Fatura bilgileri başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _faturaBilgiGetir();
        }

        // fatura bilgi silmek için metod
        private void _faturaBilgiSil()
        {
            DialogResult SilinsinMi = new DialogResult(); // silme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            SilinsinMi = MessageBox.Show("Faturayı silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SilinsinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Delete from tbl_faturabilgi where faturabilgiid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                _command(command);
                _temizle1();
                _faturaBilgiGetir();
            }
            if (SilinsinMi==DialogResult.No)
            {
                MessageBox.Show("Fatura silme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle1();
            }
        }

        //fatura bilgilerini güncellemek için metod
        private void _faturaBilgiGuncelle()
        {
            DialogResult GuncellensinMi = new DialogResult(); // güncelleme işlemi gerçekleşmeden önce onay alabilmek için veya iptal etmek için diialogresult nesnesi oluşturduk.
            GuncellensinMi = MessageBox.Show("Fatura bilgilerini güncellemek istediğinizden emin misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (GuncellensinMi==DialogResult.Yes)
            {
                NpgsqlCommand command = new NpgsqlCommand("Update tbl_faturabilgi set serino=@seri,sirano=@sira,tarih=@tarih,saat=@saat,alici=@alici,teslimeden=@teslimeden,teslimalan=@teslimalan where faturabilgiid=@id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@seri", txtSeri.Text);
                command.Parameters.AddWithValue("@sira", txtSirano.Text);
                command.Parameters.AddWithValue("@tarih", mtbTarih.Text);
                command.Parameters.AddWithValue("@saat", mtbSaat.Text);
                command.Parameters.AddWithValue("@alici", txtAlici.Text);
                command.Parameters.AddWithValue("@teslimeden", txtTeslimEden.Text);
                command.Parameters.AddWithValue("@teslimalan", txtTeslimAlan.Text);
                _command(command);
                _temizle1();
                _faturaBilgiGetir();
            }
            if (GuncellensinMi==DialogResult.No)
            {
                MessageBox.Show("Fatura bilgilerini güncelleme işlemi gerçekleşmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _temizle1();
            }
        }

        // hareketlere detayı ekleme işlemleri için metod
        private void _faturaDetay()
        {
            //Firma harekete ekleme işlemi
            if (txtFaturaId.Text != "" && cmbCari.Text == "Firma")
            {
                double miktar, fiyat, tutar;
                miktar = Convert.ToDouble(txtMiktar.Text);
                fiyat = Convert.ToDouble(txtFiyat.Text);
                tutar = miktar * fiyat;


                NpgsqlCommand command1 = new NpgsqlCommand("Insert into tbl_faturadetay (faturadetayid,urunad,miktar,fiyat,tutar,faturaid) values (@detayid,@urunad,@miktar,@fiyat,@tutar,@faturaid)",connection);
                command1.Parameters.AddWithValue("@detayid", int.Parse(txtDetayId.Text));
                command1.Parameters.AddWithValue("@urunad", txtUrunAd.Text);
                command1.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
                command1.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
                command1.Parameters.AddWithValue("@tutar", tutar);
                //command1.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
                command1.Parameters.AddWithValue("@faturaid", int.Parse(txtFaturaId.Text));
                _command(command1);

                //firma hareket tablosuna veri ekleme
                NpgsqlCommand command2 = new NpgsqlCommand("Insert into tbl_firmahareketler (firmahareketid,urunid,adet,personel,firma,fiyat,toplam,faturaid) values (@fhareketid,@urunid,@adet,@personel,@firma,@fiyat,@toplam,@faturaid)",connection);
                command2.Parameters.AddWithValue("@fhareketid", int.Parse(txtFHareketId.Text));
                command2.Parameters.AddWithValue("@urunid", int.Parse(txtUrunId.Text));
                command2.Parameters.AddWithValue("@adet", int.Parse(txtMiktar.Text));
                command2.Parameters.AddWithValue("@personel", int.Parse(txtPersonelId.Text));
                command2.Parameters.AddWithValue("@firma", int.Parse(txtFirmaId.Text));
                command2.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
                command2.Parameters.AddWithValue("@toplam", tutar);
                //command2.Parameters.AddWithValue("@toplam", decimal.Parse(txtTutar.Text));
                command2.Parameters.AddWithValue("@faturaid", int.Parse(txtFaturaId.Text));
                _command(command2);

                //alınan ürün miktarını stoktan düşmek
                NpgsqlCommand command3 = new NpgsqlCommand("Update tbl_urunler set adet=adet-@adet where urunid=@id", connection);
                command3.Parameters.AddWithValue("@adet", int.Parse(txtMiktar.Text));
                command3.Parameters.AddWithValue("@id", int.Parse(txtUrunId.Text));
                _command(command3);

                MessageBox.Show("Fatura detayları başarıyla kaydedildi.");
                _faturaBilgiGetir();
            }

            ////Musteriharekete ekleme işlemi
            else if (txtFaturaId.Text != "" && cmbCari.Text == "Müşteri")
            {
                double miktar, fiyat, tutar;
                miktar = Convert.ToDouble(txtMiktar.Text);
                fiyat = Convert.ToDouble(txtFiyat.Text);
                tutar = miktar * fiyat;
                

                NpgsqlCommand command1 = new NpgsqlCommand("Insert into tbl_faturadetay (faturadetayid,urunad,miktar,fiyat,tutar,faturaid) values (@detayid,@urunad,@miktar,@fiyat,@tutar,@faturaid)", connection);
                command1.Parameters.AddWithValue("@detayid", int.Parse(txtDetayId.Text));
                command1.Parameters.AddWithValue("@urunad", txtUrunAd.Text);
                command1.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
                command1.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
                command1.Parameters.AddWithValue("@tutar", tutar);
                //command1.Parameters.AddWithValue("@tutar", decimal.Parse(txtTutar.Text));
                command1.Parameters.AddWithValue("@faturaid", int.Parse(txtFaturaId.Text));
                _command(command1);

                // müşteri hareket tablosuna veri ekleme
                NpgsqlCommand command2 = new NpgsqlCommand("Insert into tbl_musterihareketler (musterihareketid,urunid,adet,personel,musteri,fiyat,toplam,faturaid) values (@mhareketid,@urunid,@adet,@personel,@musteri,@fiyat,@toplam,@faturaid)", connection);
                command2.Parameters.AddWithValue("@mhareketid", int.Parse(txtMHareket.Text));
                command2.Parameters.AddWithValue("@urunid", int.Parse(txtUrunId.Text));
                command2.Parameters.AddWithValue("@adet", int.Parse(txtMiktar.Text));
                command2.Parameters.AddWithValue("@personel", int.Parse(txtPersonelId.Text));
                command2.Parameters.AddWithValue("@musteri", int.Parse(txtMusteriId.Text));
                command2.Parameters.AddWithValue("@fiyat", decimal.Parse(txtFiyat.Text));
                command2.Parameters.AddWithValue("@toplam", tutar);
                //command2.Parameters.AddWithValue("@toplam", decimal.Parse(txtTutar.Text));
                command2.Parameters.AddWithValue("@faturaid", int.Parse(txtFaturaId.Text));
                _command(command2);

                //alınan ürün miktarını stoktan düşmek
                NpgsqlCommand command3 = new NpgsqlCommand("Update tbl_urunler set adet=adet-@adet where urunid=@id",connection);
                command3.Parameters.AddWithValue("@adet", int.Parse(txtMiktar.Text));
                command3.Parameters.AddWithValue("@id", int.Parse(txtUrunId.Text));
                _command(command3);

                MessageBox.Show("Fatura detayları başarıyla kaydedildi.");
                _faturaBilgiGetir();
            }
        }

        private void Frm_Faturalar_Load(object sender, EventArgs e)
        {
            _faturaBilgiGetir();
        }

        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {
            _faturaBilgiEkle();
        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            _faturaBilgiSil();
        }

        private void btnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            _faturaBilgiGuncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _temizle1();
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            _temizle2();
        }

        // ürün id sini yazarak arama işlemi gerçekleştirme işlemi
        private void btnAra_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select urunad,satisfiyat from tbl_urunler where urunid=@id", connection);
            command.Parameters.AddWithValue("@id", int.Parse(txtUrunId.Text));
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtUrunAd.Text = dataReader[0].ToString();
                txtFiyat.Text = dataReader[1].ToString();
            }
            connection.Close();
        }

        // cmbCAri de seçilen texte göre uygulanaca işlemler
        private void cmbCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCari.Text=="Firma")
            {
                txtMusteriId.Enabled = false;
                txtFirmaId.Enabled = true;
                lblM.Visible = false;
                txtMHareket.Visible = false;
                lblF.Visible = true;
                txtFHareketId.Visible = true;
            }
            if (cmbCari.Text=="Müşteri")
            {
                txtFirmaId.Enabled = false;
                txtMusteriId.Enabled = true;
                lblF.Visible = false;
                txtFHareketId.Visible = false;
                lblM.Visible = true;
                txtMHareket.Visible = true;
            }
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            _faturaDetay();
        }

        //datagriddeki bir satıra tıkladıgımızda o satırdaki bilgileri araçlara taşıyan kodlar
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSeri.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSirano.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtbTarih.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mtbSaat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAlici.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTeslimEden.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTeslimAlan.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        // datagridde satıra çift tıkladıgımızda o faturaya ait detayları farklı formda açma işlemi
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            Frm_FaturaDetaylar frm_FaturaDetaylar = new Frm_FaturaDetaylar();
            frm_FaturaDetaylar.id = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["faturabilgiid"].Value);
            frm_FaturaDetaylar.Show();
        }
    }
}
