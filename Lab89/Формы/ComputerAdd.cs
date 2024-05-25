using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lab89
{
    public partial class ComputerAdd : Form
    {
        public ComputerAdd()
        {
            InitializeComponent();
        }
        Form form1 = new Form();
        private void LaptopAdd_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Laptop(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                textBox5.Text, textBox6.Text, comboBox1.Text, comboBox2.Text);
            form1 = Application.OpenForms[0];
            Form1.Switcher = true;
            form1.Show();
            this.Close();
        }
    }
}
