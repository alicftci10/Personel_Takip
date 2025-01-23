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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Methods mt = new Methods();
            var kullanici = mt.GetKullaniciTCNO(textBox12.Text);
            PersonelDataModel model = new PersonelDataModel();

            string errormessage = "";
            if (textBox12.Text == "")
                errormessage += "TC Kimlik No boş girilemez!! \n";
            if (textBox11.Text == "")
                errormessage += "Ad boş girilemez!! \n";
            if (textBox10.Text == "")
                errormessage += "Soyad boş girilemez!! \n";
            if (textBox9.Text == "")
                errormessage += "Kullanıcı Adı boş girilemez!! \n";
            if (textBox8.Text == "")
                errormessage += "Şifre boş girilemez!! \n";
            if (textBox7.Text == "")
                errormessage += "Şifre Tekrar boş girilemez!! \n";
            if (textBox7.Text != textBox8.Text)
                errormessage += "Şifreler uyuşmuyor!! \n";


            if (errormessage == "")
            {
                if (kullanici.Id > 0)
                {
                    DialogResult result = MessageBox.Show("Bu kullanıcıya ait verileri değiştirmek istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        model.Id = kullanici.Id;
                        model.Tcno = textBox12.Text;
                        model.Ad = textBox11.Text;
                        model.Soyad = textBox10.Text;
                        model.KullaniciAdi = textBox9.Text;
                        model.Sifre = textBox8.Text;

                        if (radioButton4.Checked == true)
                            model.Yetki = "Yönetici";
                        else if (radioButton3.Checked == true)
                            model.Yetki = "Personel";

                        mt.UpdateKullanici(model);
                    }
                }
                else
                {
                    model.Tcno = textBox12.Text;
                    model.Ad = textBox11.Text;
                    model.Soyad = textBox10.Text;
                    model.KullaniciAdi = textBox9.Text;
                    model.Sifre = textBox8.Text;

                    if (radioButton4.Checked == true)
                        model.Yetki = "Yönetici";
                    else if (radioButton3.Checked == true)
                        model.Yetki = "Personel";

                    mt.AddKullanici(model);
                }
            }
            else
            {
                MessageBox.Show(errormessage);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formu_Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? Yetki = null;

            if (radioButton1.Checked == true)
                Yetki = "Yönetici";

            if (radioButton2.Checked == true)
                Yetki = "Personel";

            if (textBox1.Text == "")
                textBox1.Text = null;

            if (textBox2.Text == "")
                textBox2.Text = null;

            if (textBox3.Text == "")
                textBox3.Text = null;

            if (textBox4.Text == "")
                textBox4.Text = null;

            if (textBox5.Text == "")
                textBox5.Text = null;

            var list = ListSearch(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Yetki);
            DataGridTable(list);
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
            Formu_Temizle();
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
                else if (kullanici.Yetki == "Personel")
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
            Formu_Temizle();
            DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Methods methods = new Methods();
                methods.DeleteKullanici(id);
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

        private void textBox_sadeceSayi(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Formu_Temizle()
        {
            textBox12.Text = null;
            textBox11.Text = null;
            textBox10.Text = null;
            textBox9.Text = null;
            textBox8.Text = null;
            textBox7.Text = null;
            radioButton4.Checked = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
