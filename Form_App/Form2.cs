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
using DataAccess.Models;
using Form_App.EFOperations;

namespace Form_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcKimlik, ad, soyad, kullaniciAdi, Sifre, Yetki;
            tcKimlik = textBox2.Text;
            ad = textBox1.Text;
            soyad = textBox3.Text;
            kullaniciAdi = textBox4.Text;
            Sifre = textBox5.Text;
            Yetki = null;

            if (radioButton1.Checked == true)
                Yetki = "Yönetici";

            if (radioButton2.Checked == true)
                Yetki = "Kullanıcı";

            if (tcKimlik == "")
                tcKimlik = null;

            if (ad == "")
                ad = null;

            if (tcKimlik == "")
                tcKimlik = null;

            if (soyad == "")
                soyad = null;

            if (kullaniciAdi == "")
                kullaniciAdi = null;

            if (Sifre == "")
                Sifre = null;

            DataGridTable(tcKimlik, ad, soyad, kullaniciAdi, Sifre, Yetki);
        }

        private void DataGridTable(string? tcKimlik, string? ad, string? soyad, string? kullaniciAdi, string? Sifre, string? Yetki)
        {
            Methods methods = new Methods();
            var List = methods.GetAllKullaniciList().Select(i => new
            {
                i.Tcno,
                i.Ad,
                i.Soyad,
                i.Yetki,
                i.KullaniciAdi,
                i.Sifre
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

            dataGridView1.DataSource = List;
            dataGridView1.Columns[0].HeaderText = "TC KİMLİK NO";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "YETKİ";
            dataGridView1.Columns[4].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[5].HeaderText = "ŞİFRE";
        }
    }
}
