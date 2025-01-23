using DataAccess.Models;
using Form_App.EFOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Height = 100;
            pictureBox1.Width = 100;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label8.Text = StaticModels.ad + " " + StaticModels.soyad;
            label9.Text = StaticModels.yetki;

            try
            {
                pictureBox1.Image = Image.FromFile(StaticModels.ImageFolderUrl + StaticModels.Id + ".jpg");
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(StaticModels.ImageFolderUrl + "resimyok.jpg");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? tcKimlik, ad, soyad, kullaniciAdi, sifre, Yetki;
            tcKimlik = textBox2.Text;
            ad = textBox1.Text;
            soyad = textBox3.Text;
            kullaniciAdi = textBox4.Text;
            sifre = textBox5.Text;
            Yetki = null;

            if (radioButton1.Checked == true)
                Yetki = "Yönetici";

            if (radioButton2.Checked == true)
                Yetki = "Personel";

            if (tcKimlik == "")
                tcKimlik = null;

            if (ad == "")
                ad = null;

            if (soyad == "")
                soyad = null;

            if (kullaniciAdi == "")
                kullaniciAdi = null;

            if (sifre == "")
                sifre = null;

            var list = ListSearch(tcKimlik, ad, soyad, kullaniciAdi, sifre, Yetki);
            DataGridTable(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox1.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void DataGridTable(List<PersonelDataModel> List)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tcno", HeaderText = "TC KİMLİK NO" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Ad", HeaderText = "AD" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Soyad", HeaderText = "SOYAD" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Yetki", HeaderText = "YETKİ" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "KullaniciAdi", HeaderText = "KULLANICI ADI" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Sifre", HeaderText = "ŞİFRE" });

            dataGridView1.DataSource = List;
            dataGridView1.Columns[0].Visible = false;
        }

        private List<PersonelDataModel> ListSearch(string? tcKimlik, string? ad, string? soyad, string? kullaniciAdi, string? Sifre, string? Yetki)
        {
            Methods methods = new Methods();
            var List = methods.GetAllKullaniciList().Select(i => new PersonelDataModel
            {
                Id = i.Id,
                Tcno = i.Tcno,
                Ad = i.Ad,
                Soyad = i.Soyad,
                Yetki = i.Yetki,
                KullaniciAdi = i.KullaniciAdi,
                Sifre = i.Sifre
            }).ToList();

            if (!string.IsNullOrEmpty(tcKimlik))
                List = List.Where(i => (!string.IsNullOrEmpty(i.Tcno) && i.Tcno.ToLower().Contains(tcKimlik.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(ad))
                List = List.Where(i => (!string.IsNullOrEmpty(i.Ad) && i.Ad.ToLower().Contains(ad.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(soyad))
                List = List.Where(i => (!string.IsNullOrEmpty(i.Soyad) && i.Soyad.ToLower().Contains(soyad.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(kullaniciAdi))
                List = List.Where(i => (!string.IsNullOrEmpty(i.KullaniciAdi) && i.KullaniciAdi.ToLower().Contains(kullaniciAdi.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(Sifre))
                List = List.Where(i => (!string.IsNullOrEmpty(i.Sifre) && i.Sifre.ToLower().Contains(Sifre.ToLower()))).ToList();

            if (!string.IsNullOrEmpty(Yetki))
                List = List.Where(i => (!string.IsNullOrEmpty(i.Yetki) && i.Yetki.ToLower().Contains(Yetki.ToLower()))).ToList();

            return List;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
