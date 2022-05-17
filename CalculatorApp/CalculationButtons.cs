using System;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace CalculatorApp
{
    public partial class Form1: Form
    {
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 0;
            symbolAtTheEnd = false;
        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 1;
            symbolAtTheEnd = false;
        }
        private void TwoButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 2;
            symbolAtTheEnd = false;
        }
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 3;
            symbolAtTheEnd = false;
        }
        private void FourButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 4;
            symbolAtTheEnd = false;
        }
        private void FiveButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 5;
            symbolAtTheEnd = false;
        }
        private void SixButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 6;
            symbolAtTheEnd = false;
        }
        private void SevenButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 7;
            symbolAtTheEnd = false;
        }
        private void EightButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 8;
            symbolAtTheEnd = false;
        }
        private void NineButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 9;
            symbolAtTheEnd = false;
        }


        private void SymbolSafeInsertion(char operation)
        {
            if (!inputTextBox.Text.Equals(""))
            {
                if (symbolAtTheEnd)
                {
                    inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1) + operation;
                }
                else
                {
                    inputTextBox.Text += operation;
                    symbolAtTheEnd = true;
                }
            }
        }
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            SymbolSafeInsertion('.');
        }
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            SymbolSafeInsertion('+');
        }
        private void SubstractionButton_Click(object sender, EventArgs e)
        {
            SymbolSafeInsertion('-');
        }
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            SymbolSafeInsertion('*');

        }
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            SymbolSafeInsertion('/');
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            symbolAtTheEnd = false;
            inputTextBox.Text = "";
            outTextBox.Text = "";
        }
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text != "")
            {
                string str = inputTextBox.Text;
                Expression expression = new Expression(str);
                if (manager.IsValidExpression(str) && expression.checkSyntax())
                {
                    manager.AddRequest(expression);
                    messageLabel2.Text = expression.getCanonicalExpressionString();
                }
                inputTextBox.Text = "";
                messageLabel.Text = "";
            }
        }

    }
}
