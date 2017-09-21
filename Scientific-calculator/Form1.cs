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
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit;
        char iOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = "0";
            }

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 308;
            txtDisplay.Width = 275;
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
            txtDisplay.Width = 275;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 616;
            txtDisplay.Width = 275;
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

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
           
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            autoLabel1.Text = "";
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            autoLabel1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Arithematic_operations(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            autoLabel1.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void buttonAdv18_Click(object sender, EventArgs e)
        {
        autoLabel1.Text = "";
        switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "---";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    //Cel to Fah
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString()) + "°F";


                    break;

                case 'F':
                    //Fah to Cel
                    iFahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString()) + "°C";

                    break;
            }
        }
    }
}
