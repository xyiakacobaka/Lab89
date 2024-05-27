using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;

namespace Lab89
{
    public partial class ComputerAdd : Form
    {
        public ComputerAdd()
        {
            InitializeComponent();
        }
        private object computer;
        internal object Computer { get { return computer; } set { computer = value; } }
        /*Формы*/
        Form form1 = new Form();
        private void LaptopAdd_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            new Laptop(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                textBox5.Text, textBox6.Text, comboBox1.Text, comboBox2.Text);
            form1 = Application.OpenForms[0];
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            Form1.Switcher = true;
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PersonalComputer(textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text,
                textBox9.Text, textBox8.Text, textBox7.Text);
            form1 = Application.OpenForms[0];
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            Form1.Switcher = true;
            form1.Show();
            this.Close();
        }
    }
}
