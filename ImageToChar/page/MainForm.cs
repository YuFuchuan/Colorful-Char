using System;
using System.Windows.Forms;
using ImageToChar.function;

namespace ImageToChar.page
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string imagePath = textBox1.Text;
            string savePath = textBox2.Text;
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                GetErrorPage.Get("错误:未输入横向像素点跨度或纵向像素点跨度");
                return;
            }
            string w = textBox3.Text;
            string h = textBox4.Text;
            int.TryParse(w, out int wSpan);
            int.TryParse(h, out int hSpan);

            string imageName = GetFileName.Get(imagePath);
            
            // 使用推荐字符组
            if (checkBox1.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c256.txt", wSpan, hSpan, GrayValueString.c_256);
            }
            if (checkBox2.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c128.txt", wSpan, hSpan, GrayValueString.c_128);
            }
            if (checkBox3.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c64.txt", wSpan, hSpan, GrayValueString.c_64);
            }
            if (checkBox4.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c32.txt", wSpan, hSpan, GrayValueString.c_32);
            }
            if (checkBox5.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c16.txt", wSpan, hSpan, GrayValueString.c_16);
            }
            if (checkBox6.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c8.txt", wSpan, hSpan, GrayValueString.c_8);
            }
            if (checkBox7.Checked)
            {
                Transformation.ImageToChar(imagePath, savePath + imageName + "_c4.txt", wSpan, hSpan, GrayValueString.c_4);
            }

            // 使用自定义字符组
            string[] replaceChars =
            {
                textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text,
                textBox10.Text, textBox11.Text,
            };
            int num = 1;

            for(int index = 0; index < replaceChars.Length; ++index)
            {
                if (replaceChars[index] != "")
                {
                    Transformation.ImageToChar(imagePath, savePath + imageName + "_custom_" + num + ".txt", wSpan, hSpan, replaceChars[index]);
                    ++num;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeForm page = new WelcomeForm();
            page.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HelpForm page = new HelpForm();
            page.ShowDialog();
        }
    }
}
