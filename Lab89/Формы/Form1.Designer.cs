namespace Lab89
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сортировкиToolStripMenuItem = new ToolStripMenuItem();
            ноутбукиToolStripMenuItem = new ToolStripMenuItem();
            пКToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            treeView1.Location = new Point(13, 33);
            treeView1.Margin = new Padding(4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(405, 523);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            // 
            // button1
            // 
            button1.Location = new Point(587, 165);
            button1.Name = "button1";
            button1.Size = new Size(122, 56);
            button1.TabIndex = 1;
            button1.Text = "Добавление";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сортировкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(995, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(88, 25);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(93, 25);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сортировкиToolStripMenuItem
            // 
            сортировкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ноутбукиToolStripMenuItem, пКToolStripMenuItem });
            сортировкиToolStripMenuItem.Name = "сортировкиToolStripMenuItem";
            сортировкиToolStripMenuItem.Size = new Size(121, 25);
            сортировкиToolStripMenuItem.Text = "Сортировки";
            // 
            // ноутбукиToolStripMenuItem
            // 
            ноутбукиToolStripMenuItem.Name = "ноутбукиToolStripMenuItem";
            ноутбукиToolStripMenuItem.Size = new Size(156, 26);
            ноутбукиToolStripMenuItem.Text = "Ноутбуки";
            ноутбукиToolStripMenuItem.Click += ноутбукиToolStripMenuItem_Click;
            // 
            // пКToolStripMenuItem
            // 
            пКToolStripMenuItem.Name = "пКToolStripMenuItem";
            пКToolStripMenuItem.Size = new Size(156, 26);
            пКToolStripMenuItem.Text = "ПК";
            пКToolStripMenuItem.Click += пКToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(548, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 88);
            panel1.TabIndex = 3;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            panel1.DragLeave += panel1_DragLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 4;
            label1.Text = "Перетащите файл сюда";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 560);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(995, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 585);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Компьютеры";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem сортировкиToolStripMenuItem;
        private ToolStripMenuItem ноутбукиToolStripMenuItem;
        private ToolStripMenuItem пКToolStripMenuItem;
    }
}
