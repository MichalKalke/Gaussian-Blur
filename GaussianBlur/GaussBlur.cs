using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Diagnostics;
using SuperfastBlur;



namespace GaussianBlur
{
    public partial class GaussBlur : Form
    {
        public static string fileName;
        public static int threadsNumber = 1;
        public static int blurPower = 10;
        CheckBox lastChecked;
       public static string currectCheckBox;

        public GaussBlur()
        {
            InitializeComponent();
            threads.Value = Environment.ProcessorCount;
            threadsNumber = Environment.ProcessorCount;
            threadsSum.Text = Environment.ProcessorCount.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GaussBlur.fileName= textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            var fileName = GaussBlur.fileName;
           
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File {fileName} does not exist");
                return;
            }

            var image = Image.FromFile(fileName);
            var blur = new Gauss.GaussianBlur(image as Bitmap);

            var sw = Stopwatch.StartNew();
            var result = blur.Process(blurPower);
            result.Save("gaussianed.jpg", ImageFormat.Jpeg);
            result.Save("gaussianed.png", ImageFormat.Png);
            pictureBox1.ImageLocation = fileName;
            pictureBox2.ImageLocation = "gaussianed.png";
            time.Text = sw.ElapsedMilliseconds.ToString();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

            blurPower = blur.Value;
            label6.Text = blur.Value.ToString();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GaussBlur_Load(object sender, EventArgs e)
        {

        }
     
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
            currectCheckBox = "asm";
        }

        private void chck2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
            currectCheckBox = "C#";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void threads_Scroll(object sender, EventArgs e)
        {
           
            threadsNumber = threads.Value;
            threadsSum.Text = threads.Value.ToString();
        }
    }


}
