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
using DataAccess.DBModels;
using DataAccess.Models;
using Form_App.EFOperations;

namespace Form_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

            var list = ListSearch(tcKimlik, ad, soyad, kullaniciAdi, Sifre, Yetki);
            DataGridTable(list);
        }

        private void DataGridTable(List<PersonelDataModel> List)
        {
            dataGridView1.DataSource = List;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "TC KİMLİK NO";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "YETKİ";
            dataGridView1.Columns[5].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[6].HeaderText = "ŞİFRE";

            if (!dataGridView1.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "Düzenle",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButton);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "Sil",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButton);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                EditRow(id);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                DeleteRow(id);
            }
        }

        private void EditRow(int id)
        {
            Methods methods = new Methods();
            var kullanici = methods.GetKullanici(id);
            if (kullanici != null)
            {
                tabControl1.SelectedTab = tabPage2;
                textBox12.Text = kullanici.Tcno;
                textBox11.Text = kullanici.Ad;
                textBox10.Text = kullanici.Soyad;
                textBox9.Text = kullanici.KullaniciAdi;
                textBox8.Text = kullanici.Sifre;

                if (kullanici.Yetki == "Yönetici")
                    radioButton4.Checked = true;
                else if (kullanici.Yetki == "Kullanıcı")
                    radioButton3.Checked = true;

                MessageBox.Show($"Düzenleme için veriler yüklendi: {kullanici.Ad} {kullanici.Soyad}");
            }
            else
            {
                MessageBox.Show("Seçili kullanıcı bulunamadı.");
            }
        }

        private void DeleteRow(int id)
        {
            DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Methods methods = new Methods();
                bool success = methods.DeleteKullanici(id);
                if (success)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                    button1.PerformClick();
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinemedi.");
                }
            }
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
    }
}
