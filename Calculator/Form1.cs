using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    //https://www.youtube.com/watch?v=Is1EHXFhEe4
    public partial class From : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public From()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if((result.Text == "0") || (operation_pressed))
            {
                result.Clear();
            }
            operation_pressed = false;
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            equasion.Text = value + " " + operation;
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;

        }

        private void result_Click(object sender, EventArgs e)
        {
            equasion.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equasion.Text = "";
        }

        internal double memoryValue = 0;
        private void Memory(object sender, EventArgs e)
        {
            memoryValue = double.Parse(result.Text);
            equasion.Text = "M " + memoryValue.ToString();          
        }
    }

}
