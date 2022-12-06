using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_SmolinSD_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 f1 = new Task1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 f2 = new Task2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 f3 = new Task3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task4 f4 = new Task4();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task5 f5 = new Task5();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
