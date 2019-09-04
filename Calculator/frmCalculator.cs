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
            ;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtUserInput.Text.Length >= txtUserInput.SelectionStart + 1)
                txtUserInput.Text = txtUserInput.Text.Remove(txtUserInput.SelectionStart, 1);

            FocusInputText();
        }
    }
}
