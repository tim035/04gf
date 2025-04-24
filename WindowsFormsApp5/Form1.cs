using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string> 
        {
            " C:\\Users\\User\\Desktop\\Без имени2.jpg",
            "C:\\Users\\User\\Desktop\\Без имени1.jpg",
            "C:\\Users\\User\\Desktop\\Без имени.jpg",
        };
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            ShowImage();

        }

        private void ShowImage()
        {
            pictureBox1.ImageLocation =imagePaths[currentIndex];
            UpdateLable(); 
        }

        private void UpdateLable()
        {
            label1.Text = $"Изображения {currentIndex + 1} из {imagePaths.Count}";
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        currentIndex=(currentIndex+1)%imagePaths.Count;
            ShowImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        currentIndex=(currentIndex-1+imagePaths.Count)% imagePaths.Count;
            ShowImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
