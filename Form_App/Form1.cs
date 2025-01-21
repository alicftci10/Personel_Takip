using Form_App.EFOperations;
namespace Form_App
{
    public partial class Form1 : Form
    {
        int hak = 3;

        public Form1()
        {
            InitializeComponent();
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
            foreach (var item in mt.GetAllKullaniciList())
            {
                if (item.KullaniciAdi == textBox1.Text && item.Sifre == textBox2.Text && item.Yetki == "Yönetici" && radioButton1.Checked == true)
                {
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else if (item.KullaniciAdi == textBox1.Text && item.Sifre == textBox2.Text && item.Yetki == "Kullanýcý" && radioButton2.Checked == true)
                {
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
                        MessageBox.Show("Giriþ hakký kalmadý!!", "Personel Takip Programý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        label4.Show();
                    }
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
            label4.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
