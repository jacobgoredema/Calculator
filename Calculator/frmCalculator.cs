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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = string.Empty;
            FocusInputText();
        }

        private void FocusInputText()
        {
            txtUserInput.Focus();
        }

        private void btnZro_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void InsertTextValue(string value)
        {
            var selectionStart = txtUserInput.SelectionStart;
            txtUserInput.Text=txtUserInput.Text.Insert(txtUserInput.SelectionStart, value);

            txtUserInput.SelectionStart = selectionStart - value.Length;

            txtUserInput.SelectionLength = 0;
        }

        private void DeleteTextValue()
        {
            if (txtUserInput.Text.Length < txtUserInput.SelectionStart + 1)
                return;
            var selectionStart = txtUserInput.SelectionStart;

            txtUserInput.Text = txtUserInput.Text.Remove(txtUserInput.SelectionStart, 1);

            txtUserInput.SelectionStart = selectionStart;
            txtUserInput.SelectionLength = 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void btnPlusSign_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void btnSubtractSign_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void btnMultiplySign_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void btnPercentageSign_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }

        /// <summary>
        /// Calculate the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            var userInput = txtUserInput.Text;
            var result = ParseOperation();

            FocusInputText();
        }

        private object ParseOperation()
        {
            try
            {
                // get the user equation input.
                var input = txtUserInput.Text;

                //remove all spaces
                input = input.Replace(" ", "");
                var operation = new Operation();
                var leftSide = true;

                //loop through each character of the iput
                for (int i = 0; i < input.Length; i++)
                {
                    if("0123456789.".Any(c=>input[i]==c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                    }
                }



                return string.Empty;
            }
            catch (Exception ex)
            {

                return $"Invalid equation.{ex.Message}";
            }
        }

        /// <summary>
        /// Attempt to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="leftSide"></param>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            if(newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newCharacter;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

            FocusInputText();
        }
    }
}
