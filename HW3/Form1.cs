using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads using stream reader class TextReader
        /// </summary>
        /// <param name="s"></param>
        private void load(TextReader sr)
        {
            string File = sr.ReadToEnd();
            textBox1.Text = File;
        }

        /// <summary>
        /// opens a txt file using OpenFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFromFileStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                { textBox1.Text = File.ReadAllText(open.FileName); }
                catch
                {
                    MessageBox.Show("ERROR! COULD NOT OPEN FILE!");
                }
            }
        }

        /// <summary>
        ///  Save file dialog to save to txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files | *.txt";
            save.DefaultExt = "txt";
            if(save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, textBox1.Text);
            }
        }

        private void Load50StripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci fifty = new Fibonacci(50);
            this.load(fifty);
        }

        private void Load100StripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci hundred = new Fibonacci(100);
            this.load(hundred);
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
