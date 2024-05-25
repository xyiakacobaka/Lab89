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
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            treeView1.Location = new Point(13, 13);
            treeView1.Margin = new Padding(4);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(405, 633);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            // 
            // button1
            // 
            button1.Location = new Point(444, 13);
            button1.Name = "button1";
            button1.Size = new Size(122, 56);
            button1.TabIndex = 1;
            button1.Text = "Добавление ноутбука";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 659);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Компьютеры";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
    }
}
