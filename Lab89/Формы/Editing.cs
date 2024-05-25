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

namespace Lab89.Формы
{
    public partial class Editing : Form
    {
        Form form1 = new Form();
        private object computer;
        internal object Computer { get { return computer; } set { computer = value; } }
        Laptop laptop;
        PersonalComputer personal;
        public Editing()
        {
            InitializeComponent();
        }
        private void Editing_Load(object sender, EventArgs e)
        {
            textBox7.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            if (Computer.GetType().ToString() == "Laptop")
            {
                this.Size = new Size(Width = 630, Height = 389);
                laptop = (Laptop)computer;
                label7.Visible = true;
                label8.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                textBox1.Text = laptop.Serial;
                textBox2.Text = laptop.Model;
                textBox3.Text = laptop.Manufacturer;
                textBox4.Text = laptop.ContryManufacturer;
                textBox5.Text = laptop.Price.ToString();
                textBox6.Text = laptop.Weight.ToString();
                if (laptop.Upgrade == true)
                    comboBox1.Text = "Присутствует";
                else
                    comboBox1.Text = "Отсутствует";
                if (laptop.Mobility == true)
                    comboBox2.Text = "Присутствует";
                else
                    comboBox2.Text = "Отсутствует";
            }
            else if(Computer.GetType().ToString() == "PersonalComputer")
            {
                this.Size = new Size(Width = 630, Height= 340);
                personal = (PersonalComputer)computer;
                label9.Visible = true;
                textBox7.Visible = true;
                button1.Location = new Point(484, 107);
                textBox1.Text = personal.Serial;
                textBox2.Text = personal.Model;
                textBox3.Text = personal.Manufacturer;
                textBox4.Text = personal.ContryManufacturer;
                textBox5.Text = personal.Price.ToString();
                textBox6.Text = personal.Weight.ToString();
                textBox7.Text = personal.Type;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Computer.GetType().ToString() == "Laptop")
            {
                int i = Form1.laptops.IndexOf(laptop);
                Form1.laptops[i].Serial = textBox1.Text;
                Form1.laptops[i].Model = textBox2.Text;
                Form1.laptops[i].Manufacturer = textBox3.Text;
                Form1.laptops[i].ContryManufacturer = textBox4.Text;
                Form1.laptops[i].Price = int.Parse(textBox5.Text);
                Form1.laptops[i].Weight = int.Parse(textBox6.Text);
                if (comboBox1.Text == "Присутствует")
                    Form1.laptops[i].Upgrade = true;
                else
                    Form1.laptops[i].Upgrade = false;
                if (comboBox2.Text == "Присутствует")
                    Form1.laptops[i].Mobility = true;
                else
                    Form1.laptops[i].Mobility = false;
            }
            else if (Computer.GetType().ToString() == "PersonalComputer")
            {
                int i = Form1.personalComputers.IndexOf(personal);
                Form1.personalComputers[i].Serial = textBox1.Text;
                Form1.personalComputers[i].Model = textBox2.Text;
                Form1.personalComputers[i].Manufacturer = textBox3.Text;
                Form1.personalComputers[i].ContryManufacturer = textBox4.Text;
                Form1.personalComputers[i].Price = int.Parse(textBox5.Text);
                Form1.personalComputers[i].Weight = int.Parse(textBox6.Text);
                Form1.personalComputers[i].Type = textBox7.Text;
            }
            form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }
    }
}
