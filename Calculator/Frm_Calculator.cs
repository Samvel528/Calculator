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
    public partial class Frm_Calculator : Form
    {
        private readonly ICalculator _calculator;

        public Frm_Calculator(ICalculator calculator)
        {
            InitializeComponent();
            _calculator = calculator;
        }

        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        private void bt_PlusMinus_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text == "0," || double.Parse(tb_Result.Text) != 0 && !tb_Result.Text.Contains('-'))
            {
                tb_Result.Text = '-' + tb_Result.Text;
            }
            else if (tb_Result.Text == "0," || double.Parse(tb_Result.Text) != 0 && tb_Result.Text.Contains('-'))
            {
                tb_Result.Text = tb_Result.Text.Trim('-');
            }
        }

        private void bt_Equal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    tb_Result.Text = _calculator.Sum(resultValue, double.Parse(tb_Result.Text)).ToString();
                    break;
                case "-":
                    tb_Result.Text = _calculator.Subtract(resultValue, double.Parse(tb_Result.Text)).ToString();
                    break;
                case "*":
                    tb_Result.Text = _calculator.Multiple(resultValue, double.Parse(tb_Result.Text)).ToString();
                    break;
                case "/":
                    tb_Result.Text = _calculator.Divide(resultValue, double.Parse(tb_Result.Text)).ToString();
                    break;
                default:
                    break;
            }

            resultValue = double.Parse(tb_Result.Text);
            lb_Temp.Text = "";
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text == "0,")
            {
                tb_Result.Text = tb_Result.Text.Trim(',');
            }
            else if(tb_Result.Text.Length == 1 || tb_Result.Text.Length == 2 && tb_Result.Text.Contains('-'))
            {
                tb_Result.Text = "0";
            }
            else
            {
                tb_Result.Text = tb_Result.Text.Remove(tb_Result.Text.Length - 1, 1);
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
        }

        private void bt_ResetAll_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
            resultValue = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (tb_Result.Text == "0" && button.Text != "," || isOperationPerformed)
                tb_Result.Clear();

            isOperationPerformed = false;
            
            if(button.Text == ",")
            {
                if(!tb_Result.Text.Contains(","))
                {
                    tb_Result.Text = tb_Result.Text + ",";
                }
            }
            else
                tb_Result.Text = tb_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                bt_Equal.PerformClick();
                operationPerformed = button.Text;
                lb_Temp.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(tb_Result.Text);
                lb_Temp.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
    }
}
