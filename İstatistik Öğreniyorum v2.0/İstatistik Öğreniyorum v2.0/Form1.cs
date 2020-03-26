using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace İstatistik_Öğreniyorum_v2._0
{
    public partial class Form1 : Form
    {

        #region Metodlar

        public void formaç(Form x)
        {
            this.Hide();
            x.ShowDialog();
            this.Show();
        
        }

        #endregion


        #region Tanımlamalar 

        Çalış yeniform = new Çalış();

        #endregion

        #region Değişkenler

        public static int a1 = 0;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        #region Picture Durumu

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a1 = 1;
            formaç(yeniform);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a1 = 2;
            formaç(yeniform);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            a1 = 3;
            formaç(yeniform);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            a1 = 4;
            formaç(yeniform);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            a1 = 5;
            formaç(yeniform);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            a1 = 6;
            formaç(yeniform);
        }

    }
}
