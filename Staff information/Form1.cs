using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonelUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UR9MGB1\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True");
       
        public void Temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtsoyad.Text = "";
            TxtMeslek.Text = "";
            MskMaas.Text = "";
            CmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tBLPERSONELTableAdapter.Fill(this.personelDataSet.TBLPERSONEL);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tBLPERSONELTableAdapter.Fill(this.personelDataSet.TBLPERSONEL);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLPERSONEL(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", Txtad.Text);
            komut.Parameters.AddWithValue("@p2", Txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label9.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel başarıyla eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label9.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label9.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tıkla = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[tıkla].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[tıkla].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[tıkla].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[tıkla].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[tıkla].Cells[4].Value.ToString();
            label9.Text = dataGridView1.Rows[tıkla].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[tıkla].Cells[6].Value.ToString();

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label9.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TBLPERSONEL Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update TBLPERSONEL Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", Txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", CmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", MskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label9.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);
             komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt bilgisi başarıyla güncellendi");
        }
    }
}
