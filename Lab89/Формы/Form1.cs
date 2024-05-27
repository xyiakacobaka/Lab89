using Lab89.Формы;using System.Windows.Forms;using static System.Windows.Forms.VisualStyles.VisualStyleElement;using System.Xml.Serialization;namespace Lab89{    public partial class Form1 : Form    {        static internal List<Laptop> laptops = new List<Laptop>();        static internal List<PersonalComputer> personalComputers = new List<PersonalComputer>();        static internal bool Switcher = false;        static internal bool SwitcherForms = false;
        private bool Writer = false;        private string inputFileName;        TreeNode treeNode = new TreeNode("Компьютеры");
        /*Формы*/
        ComputerAdd laptopAdd = new ComputerAdd();        Editing Editing = new Editing();        public Form1()        {            InitializeComponent();        }        private void Form1_Load(object sender, EventArgs e)        {            treeNode.Nodes.Add(new TreeNode("Ноутбуки"));            treeNode.Nodes.Add(new TreeNode("Персональные компьютеры"));            treeView1.Nodes.Add(treeNode);            treeNode.Expand();
        }        private void button1_Click(object sender, EventArgs e)        {            try            {                laptopAdd.ShowDialog();                if (Switcher == true)
                {
                    NodeFill(0);
                    NodeFill(1);
                    Switcher = false;                }            }            catch (ArgumentOutOfRangeException) { }        }        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)        {            switch (e.Action)            {
                case TreeViewAction.ByMouse:                    if (e.Node.Text != "Компьютеры" && e.Node.Text != "Ноутбуки" && e.Node.Text != "Персональные компьютеры")
                    {                        if (e.Node.Parent.Text == "Ноутбуки")
                        {
                            Laptop laptop = (Laptop)Find(e.Node.Text);
                            DialogResult result = MessageBox.Show(
                                laptop.Information() +
                                $"Изменить характеристики компьютера?(Кнопка \"Да\")\n" +
                                $"Удалить компьютер?(Кнопка \"Нет\")\n" +
                                $"Закрыть окно?(Кнопка \"Отмена\")\n",
                                "Информация о товаре",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.None,
                                MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                Editing.Computer = laptop;
                                Editing.ShowDialog();
                            }
                            else if (result == DialogResult.No)
                            {
                                laptops.Remove(laptop);
                            }
                            NodeFill(0);
                        }                        else if (e.Node.Parent.Text == "Персональные компьютеры")
                        {
                            PersonalComputer personal = (PersonalComputer)Find(e.Node.Text);
                            DialogResult result = MessageBox.Show(
                                personal.Information() +
                                $"Изменить характеристики компьютера?(Кнопка \"Да\")\n" +
                                $"Удалить компьютер?(Кнопка \"Нет\")\n" +
                                $"Закрыть окно?(Кнопка \"Отмена\")\n",
                                "Информация о товаре",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.None,
                                MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                Editing.Computer = personal;
                                Editing.ShowDialog();
                            }
                            else if (result == DialogResult.No)
                            {
                                personalComputers.Remove(personal);
                            }
                            NodeFill(1);
                        }                    }                break;            }        }        private object Find(string Node)        {            foreach (Laptop laptop in laptops)
            {                if (((Computer)laptop).ToString() == Node)                    return laptop;            }            foreach (PersonalComputer personalComputer in personalComputers)            {                if (((Computer)personalComputer).ToString() == Node)                    return personalComputer;            }            throw new Exception("Не существует такого компьютера");        }        private void NodeFill(int i)
        {
            treeNode.Nodes[i].Nodes.Clear();
            if (i == 0)
            {
                foreach (Laptop laptop in laptops)
                {
                    treeNode.Nodes[0].Nodes.Add(((Computer)laptop).ToString());
                }
            }
            else if (i == 1)
            {
                foreach (PersonalComputer personalComputer in personalComputers)
                {
                    treeNode.Nodes[1].Nodes.Add(((Computer)personalComputer).ToString());
                }
            }
        }
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] strings = (string[])e.Data.GetData(DataFormats.FileDrop);
            label1.Text = "Перетащите файл сюда";
            if (strings.Count() != 1)
                throw new Exception("Перетащите только 1 файл");
            else
            {
                inputFileName = strings[0];
                Writer = false;
            }

        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                label1.Text = "Отпустите мышь";
                bool allowFilesDrop = true;
                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop, true))
                    allowFilesDrop = new FileInfo(f).Extension == ".txt";
                if (allowFilesDrop)
                    e.Effect = DragDropEffects.All;
            }
        }
        private void panel1_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Перетащите файл сюда";
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Writer == false)
                {

                    StreamReader reader = new StreamReader(inputFileName);
                    while (reader.Peek() > 1)
                    {
                        string[] strings = reader.ReadLine().Split(";");
                        if (strings.Count() == 8)
                        {
                            new Laptop(strings[0], strings[1], strings[2], strings[3],
                            strings[4], strings[5], strings[6], strings[7]);
                        }
                        else if (strings.Count() == 7)
                        {
                            new PersonalComputer(strings[0], strings[1], strings[2], strings[3],
                                strings[4], strings[5], strings[6]);
                        }
                    }              
                    NodeFill(0);
                    NodeFill(1);
                    Writer = true;
                    reader.Close();
                }

            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Невозможно найти файл");
            }
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("321.txt", false);
                XmlSerializer xmlSerializerL = new XmlSerializer(typeof(Laptop));
                XmlSerializer xmlSerializerPC = new XmlSerializer(typeof(PersonalComputer));
                using (Stream x = File.Create("Laptop.xml"))
                {                 
                    foreach (Laptop laptop in laptops)
                    {
                        streamWriter.WriteLine(laptop.ToString());
                        xmlSerializerL.Serialize(x, laptop);
                    }
                }
                using (Stream x = File.Create("PersonalComputer.xml"))
                {
                    foreach (PersonalComputer personalComputer in personalComputers)
                    {
                        streamWriter.WriteLine(personalComputer.ToString());
                        xmlSerializerPC.Serialize(x, personalComputer);
                    }
                }
                streamWriter.Close();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Невозможно найти файл");
            }
        }
        private void ноутбукиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceSort priceSort = new PriceSort();
            laptops.Sort(priceSort);
            NodeFill(0);
        }
        private void пКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceSort priceSort = new PriceSort();
            personalComputers.Sort(priceSort);
            NodeFill(1);
        }
    }}