using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace İstatistik_Öğreniyorum_v2._0
{
    public partial class Çalış : Form
    {
        #region Metodlar

        public void baglan() // Bu metod ile veri tabanına bağlandık
        {
            yolx = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=İstatistik.accdb";

            bağlantı = new OleDbConnection(yolx);

            sorgu = "select * from istatistik";

            komut = new OleDbCommand(sorgu, bağlantı);

            adaptör = new OleDbDataAdapter(komut);
            bağlantı.Open();
            adaptör.Fill(tablo);
            bağlantı.Close();
           
        }

        public void göster1()
        {
            t1 = t1 + 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + t1 + ".png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + (t1 + 1) + ".png");
            richTextBox1.Text = tablo.Rows[t1-1]["Nott"].ToString();
            richTextBox2.Text = tablo.Rows[t1]["Nott"].ToString();
        //
        }

        public void göster2()
        {
            dialog = MessageBox.Show("Konu ile ilgili başka çalışılacak not kalmadı.\nYeniden başlamak için Tamam,\nKaldığınız yerden devam etmek için Hayır\nAnasayfaya dönmek için İptal'e basınız", "Uyarı", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                t1 = t2;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + t1 + ".png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + (t1 + 1) + ".png");
                richTextBox1.Text = tablo.Rows[t1-1]["Nott"].ToString();
                richTextBox2.Text = tablo.Rows[t1]["Nott"].ToString();
            }

            else if (dialog == DialogResult.Cancel)
            {
                this.Close();

            }
        }

        public void göster3()
        {
            t1 = t1 - 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + t1 + ".png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + (t1 + 1) + ".png");
            richTextBox1.Text = tablo.Rows[t1-1]["Nott"].ToString();
            richTextBox2.Text = tablo.Rows[t1]["Nott"].ToString();
        
        }

        #endregion

        #region Tanımlamalar

        Color renk1,renk2;
        ColorDialog renk = new ColorDialog();
        TimeSpan tszaman;
        #endregion

        #region Değişkenler

        DateTime date1, date2, date3,date4;

        DataSet dtset=new DataSet();

        string yolx, yoly; // veri tabanının bağlandığı değişkenler

        OleDbConnection bağlantı, bağlantı2;

        string sorgu, sorgu2;

        OleDbCommand komut, komut2;

        OleDbDataAdapter adaptör, adaptör2;

        DataTable tablo = new DataTable();

        DataSet datast = new DataSet();

        DialogResult sonuc;

        DialogResult dialog;

        int x = 0;
        int t1 = 1,t2;

        int saat1, saat2, dk1, dk2, sn1, sn2;
        double tzaman1, tzaman2;
        double verim;
        int z = 0;

        #endregion



        public Çalış()
        {
            InitializeComponent();
        }

        private void Çalış_Load(object sender, EventArgs e)
        {
            renk1 = SystemColors.Control;
            tablo.Clear();
            baglan();
            x = Form1.a1;
            date1 =Convert.ToDateTime( DateTime.Now.ToLongTimeString());
            label1.Text = DateTime.Now.ToLongTimeString();
            tszaman = new TimeSpan(00, 00, 00);
            timer2.Start();
            timer1.Start();
            
            
            #region Başlangıç

            if (x==1)
            {
                t1 = 1;
                t2 = 1;
            }

            else if (x==2)
            {
                t1 = 18;
                t2 = 18;
            }

            else if (x == 3)
            {
                t1 = 42;
                t2 = 42;
            }

            else if (x == 4)
            {
                t1 = 81;
                t2 = 81;
            }

            else if (x == 5)
            {
                t1 = 126;
                t2 = 126;
            }

            else if (x == 6)
            {
                t1 = 168;
                t2 = 168;
            }

            pictureBox1.Image = Image.FromFile(Application.StartupPath+"\\Resim\\"+t1+".png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Resim\\" + (t1 + 1) + ".png");
            richTextBox1.Text=tablo.Rows[t1-1]["Nott"].ToString();
            richTextBox2.Text = tablo.Rows[t1]["Nott"].ToString();
            #endregion
        }

     
        private void pictureBox4_Click(object sender, EventArgs e)
        {

            #region Sağ Ok

            if (x == 1 && t1<17)
            {
                göster1();
            }

            else if (x==1 && t1==17)
            {
                göster2();
            }

            else if (x==2 && t1<41)
            {
                göster1();
            }

            else if (x==2 && t1==41)
            {
                 göster2();
            }

            else if (x == 3 && t1 < 80)
            {
                göster1();
            }

            else if (x == 3 && t1 == 80)
            {
                göster2();
            }

            else if (x == 4 && t1 < 125)
            {
                göster1();
            }

            else if (x == 4 && t1 == 125)
            {
                göster2();
            }

            else if (x == 5 && t1 < 167)
            {
                göster1();
            }

            else if (x == 5 && t1 == 167)
            {
                göster2();
            }

            else if (x == 6 && t1 < 204)
            {
                göster1();
            }

            else if (x == 6 && t1 == 204)
            {
                göster2();
            }

            #endregion
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            #region Sol Ok

            if (x==1 && t1>1 && t1<18)
            {
                göster3();
            }

            else if (x==2 && t1>18)
            {
                göster3();
            }

            else if (x == 3 && t1 > 42)
            {
                göster3();
            }

            else if (x == 4 && t1 > 81)
            {
                göster3();
            }

            else if (x == 5 && t1 > 126)
            {
                göster3();
            }

            else if (x == 6 && t1 >168)
            {
                göster3();
            }

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
           richTextBox1.ReadOnly = false;
           richTextBox1.BackColor = Color.White;
           richTextBox1.SelectionStart = richTextBox1.Text.Length;
           richTextBox1.Focus();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                yoly = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=İstatistik.accdb";
                OleDbConnection baglanti = new OleDbConnection(yoly);
                OleDbCommand komutt = new OleDbCommand("Update istatistik set Nott='" + richTextBox1.Text + "' where ID=" + t1, baglanti);
                baglanti.Open();
                komutt.ExecuteNonQuery();
                baglanti.Close();
                tablo.Clear();
                dtset.Clear();
                baglan();
                richTextBox1.ReadOnly = true;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.Focus();
                richTextBox1.BackColor = renk1;

            }

            catch { MessageBox.Show("Kayıt işlemi yapılırken tek tırnak veya çift tırnak kullanımında bir hata olmuş olabilir.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

            if (renk.ShowDialog()==DialogResult.OK)
            {
                renk1 = renk.Color;
                richTextBox1.BackColor = renk.Color;
               
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (renk.ShowDialog() == DialogResult.OK)
            {
                renk2 = renk.Color;
                richTextBox1.ForeColor = renk2;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date3 = Convert.ToDateTime((Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - date1).ToString());
            label3.Text = (Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - date1).ToString();
            label5.Text = (Convert.ToDateTime(DateTime.Now.ToLongTimeString()) - date1).ToString();
            saat1 = Convert.ToInt32(date3.Hour);
           
            saat2 = Convert.ToInt32(date4.Hour);
             dk1 = Convert.ToInt32(date3.Minute);
             dk2 = Convert.ToInt32(date4.Minute);
             sn1 = Convert.ToInt32(date3.Second);
             sn2 = Convert.ToInt32(date4.Second);
             tzaman1 = saat1 * 360 + dk1 * 60 + sn1;
             tzaman2 = saat2 * 360 + dk2 * 60 + sn2;


             verim = (tzaman2 / tzaman1) * 100;
             label6.Text ="%"+ verim.ToString();

        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {

            TimeSpan ekleneceksaat = TimeSpan.FromSeconds(1);
            tszaman = tszaman.Add(ekleneceksaat);
            label4.Text = tszaman.ToString();
            date4 = Convert.ToDateTime(label4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (z%2==0)
            {
                groupBox2.Visible = true;
                z++;
            }

            else
            {
                groupBox2.Visible = false;
                z++; 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dialog = MessageBox.Show("Anasayfaya dönmek mi istiyorsunuz?","Soru",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (dialog==DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }
}
