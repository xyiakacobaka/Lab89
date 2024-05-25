using System.Windows.Forms;

namespace Lab89
{
    public partial class Form1 : Form
    {
        static internal List<Computer> computers = new List<Computer>();
        static internal List<Laptop> laptops = new List<Laptop>();
        static internal List<PersonalComputer> personalComputers = new List<PersonalComputer>();
        TreeNode treeNode = new TreeNode("Компьютеры");
        /*Формы*/
        LaptopAdd laptopAdd = new LaptopAdd();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeNode.Nodes.Add(new TreeNode("Ноутбуки"));
            treeNode.Nodes.Add(new TreeNode("Персональные компьютеры"));
            treeView1.Nodes.Add(treeNode);
            treeNode.Expand();
            Laptop laptop1 = new Laptop("Katana 17", "B12UCX-1023XRU", "MSI", "Китай", "132", "61432", "Присутствует", "Присутствует");
            //treeNode.Nodes[0].Nodes.Add(laptop1.ToString());
            Laptop laptop2 = new Laptop("Katana 17", "B12UCX-1023XRU", "MSI", "Китай", "132", "61432", "Присутствует", "Присутствует");
            //treeNode.Nodes[0].Nodes.Add(laptop2.ToString());
            treeNode.Nodes[0].Nodes.Add(computers[0].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                laptopAdd.ShowDialog();
                treeNode.Nodes[0].Nodes.Add(computers[computers.Count - 1].ToString());
            }
            catch(ArgumentOutOfRangeException) { }
        }
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            switch ((e.Action))
            {               
                case TreeViewAction.ByMouse:
                    MessageBox.Show(e.Node.ToString());
                    break;
            }
        }
    }
}
