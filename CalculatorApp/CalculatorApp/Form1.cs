using System.Diagnostics;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Boolean symbolButtonClicked = false;
        Boolean firstNumberClicked = false;
        List<string> operations = new List<string>();
        List<decimal> operands = new List<decimal>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator by Logan Dye";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string OutputNumber = button.Text;
                if (!firstNumberClicked)
                {
                    EqualsButton.BackColor = Color.FromArgb(229, 155, 51);
                    EqualsButton.ForeColor = Color.White;
                    OutputLabel.Text = OutputNumber;
                    firstNumberClicked = true;
                }
                else
                {
                    OutputLabel.Text += OutputNumber;
                }
            }
        }

        private void ResetButtons(object sender, EventArgs e)
        {
            MultiplyButton.ForeColor = Color.White;
            MultiplyButton.BackColor = Color.FromArgb(229, 155, 51);
            DivisionButton.ForeColor = Color.White;
            DivisionButton.BackColor = Color.FromArgb(229, 155, 51);
            AddButton.ForeColor = Color.White;
            AddButton.BackColor = Color.FromArgb(229, 155, 51);
            SubtractButton.ForeColor = Color.White;
            SubtractButton.BackColor = Color.FromArgb(229, 155, 51);



        }

        private void SymbolButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button != NegativeButton && button != PercentButton)
                {
                    ResetButtons(sender, e);
                    button.BackColor = Color.White;
                    button.ForeColor = Color.FromArgb(229, 155, 51);
                    firstNumberClicked = false;

                    decimal outputNumber = Decimal.Parse(OutputLabel.Text);
                    operands.Add(outputNumber);
                    if (sender == MultiplyButton)
                    {
                        operations.Add("*");
                    }
                    if (sender == AddButton)
                    {
                        operations.Add("+");

                    }
                    if (sender == SubtractButton)
                    {
                        operations.Add("-");

                    }
                    if (sender == DivisionButton)
                    {
                        operations.Add("/");

                    }
                }
            }

        }

        private void CalculateEquasion(object sender, EventArgs e)
        {
            operands.Add(Decimal.Parse(OutputLabel.Text));
            EqualsButton.BackColor = Color.White;
            EqualsButton.ForeColor = Color.Black;
            firstNumberClicked = false;

            Debug.WriteLine(operands.Count);

            for (int i = 0; i < operations.Count; i++)
            {
                string operation = operations[i];

                if (operation == "*" || operation == "/")
                {
                    decimal operand = operands[i];
                    decimal nextOperand = operands[i + 1];
                    decimal result = 0;
                    switch (operation)
                    {
                        case "*":
                            result = operand * nextOperand;
                            break;
                        case "/":
                            if (nextOperand == 0)
                            {
                                OutputLabel.Text = "Err...";
                                operands.Clear();
                                operations.Clear();
                                return;
                            }
                            result = operand / nextOperand;
                            break;
                    }

                    operands[i] = result;
                    operands.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    i--;
                }


            }
            decimal finalResult = operands[0];
            Debug.WriteLine(finalResult);
            for (int i = 0; i < operands.Count; i++)
            {

                if (i + 1 < operands.Count)
                {
                    string operation = operations[i];

                    decimal nextOperand = operands[i + 1];
                    switch (operation)
                    {
                        case "+":
                            finalResult += nextOperand;
                            break;
                        case "-":
                            finalResult -= nextOperand;
                            break;
                    }
                }
            }

            OutputLabel.Text = finalResult.ToString();


            operands.Clear();
            operations.Clear();
            ResetButtons(sender, e);




        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            operands.Clear();
            operations.Clear();
            ResetButtons(sender, e);
            EqualsButton.BackColor = Color.FromArgb(229, 155, 51);
            EqualsButton.ForeColor = Color.White;
            OutputLabel.Text = "0";
            firstNumberClicked = false;


        }
    }
}
