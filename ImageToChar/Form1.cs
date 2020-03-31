using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToChar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagePath = textBox1.Text;
            string savePath = textBox2.Text;
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                textBox3.Text = "2";
                textBox4.Text = "3";
            }
            string w = textBox3.Text;
            string h = textBox4.Text;
            int.TryParse(w, out int wSpan);
            int.TryParse(h, out int hSpan);

            string imageName = GetFileName.Get(imagePath);
            
            if (checkBox1.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_256.txt", wSpan, hSpan, GrayValueString.c_256);
            }
            if (checkBox2.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_128.txt", wSpan, hSpan, GrayValueString.c_128);
            }
            if (checkBox3.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_64.txt", wSpan, hSpan, GrayValueString.c_64);
            }
            if (checkBox4.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_32.txt", wSpan, hSpan, GrayValueString.c_32);
            }
            if (checkBox5.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_16.txt", wSpan, hSpan, GrayValueString.c_16);
            }
            if (checkBox6.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_8.txt", wSpan, hSpan, GrayValueString.c_8);
            }
            if (checkBox7.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_4.txt", wSpan, hSpan, GrayValueString.c_4);
            }
            if (checkBox8.Checked)
            {
                if (textBox5.Text == "")
                {
                    textBox5.Text = " ";
                }
                string replaceChar = textBox5.Text;
                Transformation.ImageToChar(imagePath, savePath + imageName + "_.txt", wSpan, hSpan, replaceChar);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome page = new Welcome();
            page.ShowDialog();
        }
    }
}
