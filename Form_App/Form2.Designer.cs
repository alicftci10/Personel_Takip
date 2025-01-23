namespace Form_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            label16 = new Label();
            button6 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(975, 598);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(967, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanıcı Ara";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 223);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(317, 39);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 19;
            button1.Text = "ARA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 238);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 16;
            label6.Text = "Şifre";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(142, 236);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 157);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Yetki";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F);
            radioButton2.Location = new Point(215, 157);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Personel";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.Location = new Point(142, 157);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 12;
            radioButton1.Text = "Yönetici";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 199);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 120);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 9;
            label2.Text = "Adı";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(142, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(142, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(142, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(142, 39);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox_sadeceSayi;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(967, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kullanıcı İşlemleri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 266);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 42;
            label10.Text = "Şifre Tekrar";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(135, 264);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 225);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 40;
            label11.Text = "Şifre";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(135, 223);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 23);
            textBox8.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 144);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 38;
            label12.Text = "Yetki";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F);
            radioButton3.Location = new Point(208, 144);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 19);
            radioButton3.TabIndex = 37;
            radioButton3.TabStop = true;
            radioButton3.Text = "Personel";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Font = new Font("Segoe UI", 9F);
            radioButton4.Location = new Point(135, 144);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 19);
            radioButton4.TabIndex = 36;
            radioButton4.TabStop = true;
            radioButton4.Text = "Yönetici";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 186);
            label13.Name = "label13";
            label13.Size = new Size(73, 15);
            label13.TabIndex = 35;
            label13.Text = "Kullanıcı Adı";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 107);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 34;
            label14.Text = "Soyadı";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 67);
            label15.Name = "label15";
            label15.Size = new Size(25, 15);
            label15.TabIndex = 33;
            label15.Text = "Adı";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(135, 184);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(143, 23);
            textBox9.TabIndex = 32;
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(135, 105);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(143, 23);
            textBox10.TabIndex = 31;
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Location = new Point(135, 65);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(143, 23);
            textBox11.TabIndex = 30;
            // 
            // textBox12
            // 
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Location = new Point(135, 26);
            textBox12.MaxLength = 11;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(143, 23);
            textBox12.TabIndex = 29;
            textBox12.KeyPress += textBox_sadeceSayi;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 28);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 28;
            label16.Text = "TC Kimlik No";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ScrollBar;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(135, 323);
            button6.Name = "button6";
            button6.Size = new Size(129, 29);
            button6.TabIndex = 27;
            button6.Text = "FORMU TEMİZLE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ScrollBar;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.RoyalBlue;
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 9F);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(33, 323);
            button9.Name = "button9";
            button9.Size = new Size(83, 29);
            button9.TabIndex = 24;
            button9.Text = "KAYDET";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1016, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1016, 162);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 24;
            label8.Text = "Aktif Kullanıcı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1016, 190);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 25;
            label9.Text = "Yetki";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1169, 629);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private Label label12;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label16;
        private Button button6;
        private Button button9;
    }
}