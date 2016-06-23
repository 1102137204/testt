using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tlsColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                output += item.ToolTipText + "\r\n";
            }

            MessageBox.Show(output);
        }

        private void tlsCopy_Click(object sender, EventArgs e)
        {
            textBox1.Text = 敲鍵盤快.Text;
        }

        private void tlsColorRed_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkRed;
        }

        private void tlsColorGreen_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkGreen;
        }

        private void tlsColorBlue_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkBlue;
        }

        private void tlsColorPurple_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
        }
    }
}
