using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            txtDisplay.Width = 270;
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 616;
            txtDisplay.Width = 581;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 308;
            txtDisplay.Width = 270;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 920;
            txtDisplay.Width = 581;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 920;
            txtDisplay.Width = 581;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 920;
            txtDisplay.Width = 581;
        }
    }
}
