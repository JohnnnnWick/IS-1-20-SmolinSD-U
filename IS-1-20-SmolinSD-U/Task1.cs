using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_1_20_SmolinSD_U
{
    public partial class Task1 : Form
    {
        abstract class Complektac<S>
        {
            public int Price;
            public int Yearofiss;
            public S Articul;

            public Complektac(int Price, int Yearofiss, S Articul)
            {
                this.Price = Price;
                this.Articul = Articul;
                this.Yearofiss = Yearofiss;
            }

            public void Display()
            {
                Console.WriteLine($"Цена{Price}, ГодВып{Yearofiss}, Артикул: {Articul} ");
            }
        }
        class HardDrives<S> : Complektac<S>
        {
            public int Turnovers { get; set; }
            public int Interfac { get; set; }
            public int Volume { get; set; }


            public HardDrives(int Price, int Yearofiss, S Articul, int Turnovers, int Interfac, int Volume) : base(Price, Yearofiss, Articul)
            {
                this.Turnovers = Turnovers;
                this.Interfac = Interfac;
                this.Volume = Volume;
            }
            public void Display()
            {
                Console.WriteLine($"Количоборотов{Turnovers}, Интерфейс{Interfac}, Объём{Volume}, Артикуль{Articul}, Цена{Price}, ГодВып{Yearofiss}");
            }
        }
        class Videoc<S> : Complektac<S>
        {
            public int Memory { get; set; }
            public int Freq { get; set; }
            public string Manuf { get; set; }

            public Videoc(int Price, int Yearofiss, S Articul, int Memory, int Freq, string Manuf) : base(Price, Yearofiss, Articul)
            {
                this.Manuf = Manuf;
                this.Freq = Freq;
                this.Memory = Memory;
            }
            public new void Display()
            {
                Console.WriteLine($" Артикуль{Articul}, Цена{Price}, ГодВып{Yearofiss}, Частота{Freq}, Производитель{Manuf}, Объём памяти{Memory}");
            }
        }
        public Task1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HardDrives<int> i1 = new HardDrives<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox9.Text));
            listBox1.Items.Add($"Цена {textBox1.Text}");
            listBox1.Items.Add($"ГодВыпуска {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Кол-во оборотов {textBox3.Text}");
            listBox1.Items.Add($"Интерфейс {textBox4.Text}");
            listBox1.Items.Add($"Объем {textBox5.Text}");
            i1.Display();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Videoc<int> g1 = new Videoc<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text);
            listBox1.Items.Add($"Цена {textBox1.Text}");
            listBox1.Items.Add($"Год {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Частота {textBox6.Text}");
            listBox1.Items.Add($"Производитель {textBox7.Text}");
            listBox1.Items.Add($"Объем памяти {textBox8.Text}");
            g1.Display();
        }
    }
}
