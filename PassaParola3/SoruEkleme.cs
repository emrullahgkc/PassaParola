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
namespace PassaParola3
{
    public partial class SoruEkleme : Form
    {
        public SoruEkleme()
        {
            InitializeComponent();
        }
        SqlBaglantisi conn = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into SORU(SORU,CEVAP) values(@P1,@P2)", conn.baglanti());
                komut.Parameters.AddWithValue("@P1", richTextBox1.Text);
                komut.Parameters.AddWithValue("@P2", richTextBox2.Text);
                komut.ExecuteNonQuery();
                conn.baglanti().Close();
                MessageBox.Show("SORU EKLENMİŞTİR.");

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox2.Text.ToLower();
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
        }
    }
}
