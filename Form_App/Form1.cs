using Form_App.EFOperations;
using DataAccess.Models;
namespace Form_App
{
    public partial class Form1 : Form
    {
        int hak = 3;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods mt = new Methods();
            var y�netici = mt.GetAllKullaniciList().FirstOrDefault(i => i.KullaniciAdi == textBox1.Text && i.Sifre == textBox2.Text && i.Yetki == "Y�netici" && radioButton1.Checked == true);
            var personel = mt.GetAllKullaniciList().FirstOrDefault(i => i.KullaniciAdi == textBox1.Text && i.Sifre == textBox2.Text && i.Yetki == "Personel" && radioButton2.Checked == true);
            if (y�netici != null)
            {
                StaticModels.Id = y�netici.Id;
                StaticModels.tcno = y�netici.Tcno;
                StaticModels.ad = y�netici.Ad;
                StaticModels.soyad = y�netici.Soyad;
                StaticModels.yetki = y�netici.Yetki;
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (personel != null)
            {
                StaticModels.Id = personel.Id;
                StaticModels.tcno = personel.Tcno;
                StaticModels.ad = personel.Ad;
                StaticModels.soyad = personel.Soyad;
                StaticModels.yetki = personel.Yetki;
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else
            {
                hak--;
                label6.Text = hak.ToString();
                if (hak == 0)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Giri� hakk� kalmad�!!", "Personel Takip Program�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullan�c� Ad� veya �ifre Yanl��", "Personel Takip Program�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}