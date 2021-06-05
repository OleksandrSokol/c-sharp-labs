using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        Double rememberNumber = 0;
        bool isOperationPerfomed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || this.isOperationPerfomed)
                textBox_Result.Clear();
            Button btn = (Button)sender;
            if(btn.Text == ",")
            {
                if (!textBox_Result.Text.Contains(","))
                {
                    textBox_Result.Text += btn.Text;
                }
            } else {
                textBox_Result.Text += btn.Text;
            }
            this.isOperationPerfomed = false;
        }

        private void operator_btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(this.resultValue != 0)
            {
                button16.PerformClick();
                this.operationPerformed = btn.Text;
                labelCurrentOperation.Text = this.resultValue + " " + this.operationPerformed;
                this.isOperationPerfomed = true;
            }
            this.operationPerformed = btn.Text;
            this.resultValue = Convert.ToDouble(textBox_Result.Text);
            labelCurrentOperation.Text = this.resultValue + " " + this.operationPerformed;
            this.isOperationPerfomed = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            this.resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (this.operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (this.resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (this.resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (this.resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (this.resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            this.resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(this.resultValue != 0)
            {
                this.rememberNumber = this.resultValue;
                this.resultValue = 0;
                textBox_Result.Text = "";
            }
               
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (this.rememberNumber != 0)
                textBox_Result.Text = this.rememberNumber.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.rememberNumber = 0;
        }
    }
}
