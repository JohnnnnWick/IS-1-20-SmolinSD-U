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
        abstract class Complektac<S> //Создание абстрактного класса, использующий обобщёный тип
        {
            public int Price; //поле
            public int Yearofiss; //тоже поле
            public S Articul;// а это обобщёный тип данных

            public Complektac(int Price, int Yearofiss, S Articul) //конструктор который принимает и инициализирует поля класса
            {
                this.Price = Price;
                this.Articul = Articul;
                this.Yearofiss = Yearofiss;
            }

            public void Display()//виртуальный метод вывода полей класса
            {
                Console.WriteLine($"Цена{Price}, ГодВып{Yearofiss}, Артикуль: {Articul} ");
            }
        }
        class HardDrives<S> : Complektac<S>//наследованный класс, юзает обобщ тип
        {
            public int Turnovers { get; set; }//поля
            public int Interfac { get; set; }//поле
            public int Volume { get; set; }//pole

            //инициализация свойств
            public HardDrives(int Price, int Yearofiss, S Articul, int Turnovers, int Interfac, int Volume) : base(Price, Yearofiss, Articul)
            {
                this.Turnovers = Turnovers;
                this.Interfac = Interfac;
                this.Volume = Volume;
            }
            public void Display() //переопределённый метод для вывода инфы
            {
                Console.WriteLine($"Количоборотов{Turnovers}, Интерфейс{Interfac}, Объём{Volume}, Артикуль{Articul}, Цена{Price}, ГодВып{Yearofiss}");
            }
        }
        class Videoc<S> : Complektac<S> //наслед класс, юзает обобщ тип
        {
            public int Memory { get; set; }
            public int Freq { get; set; }
            public string Manuf { get; set; }
            //инициализируем свойства
            public Videoc(int Price, int Yearofiss, S Articul, int Memory, int Freq, string Manuf) : base(Price, Yearofiss, Articul)
            {
                this.Manuf = Manuf;
                this.Freq = Freq;
                this.Memory = Memory;
            }
            public new void Display()//переопределённый метод для вывода инфы
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

        private void button1_Click(object sender, EventArgs e) //выполняет вывод инфы в бд
        {
            listBox1.Items.Clear();//клир
            //создание экз класса, в котор нужен текстбокс
            HardDrives<int> i1 = new HardDrives<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox9.Text));
            listBox1.Items.Add($"Цена {textBox1.Text}");
            listBox1.Items.Add($"ГодВыпуска {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Кол-во оборотов {textBox3.Text}");
            listBox1.Items.Add($"Интерфейс {textBox4.Text}");
            listBox1.Items.Add($"Объем {textBox5.Text}");
            //вызывание метода
            i1.Display();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//клир
            //создание экз класса, в котор нужен текстбокс
            Videoc<int> g1 = new Videoc<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text);
            listBox1.Items.Add($"Цена {textBox1.Text}");
            listBox1.Items.Add($"Год {textBox2.Text}");
            listBox1.Items.Add($"Артикул {textBox9.Text}");
            listBox1.Items.Add($"Частота {textBox6.Text}");
            listBox1.Items.Add($"Производитель {textBox7.Text}");
            listBox1.Items.Add($"Объем памяти {textBox8.Text}");
            g1.Display();//вызывание метода
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
