using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRover
{
    public partial class MarsRoverForm : Form
    {
        public MarsRoverForm()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.ToUpper();
            string[] lines = input.Split(new string[] { "\n"}, StringSplitOptions.None);
            bool  isValid = ValidateInput(lines);
            if (!isValid)
                return;
            MarsPackage inputPackage = MarsRoverWorkflow.PreparePackage(lines);
            MarsPackage resultMove = MarsRoverWorkflow.MoveRover(inputPackage);
            if (!resultMove.IsSuccessful)
            {
                MessageBox.Show(resultMove.ErrorMessage, "Yapılmak İstenilen Hareket Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetControls(resultMove);
        }

        internal bool ValidateInput(string[] lines)
        {
            bool isValid = true;
            var validationResult = MarsRoverValidation.ValidateInputLines(lines);
            if (!validationResult.IsSuccessful)
            {
                MessageBox.Show(validationResult.ErrorMessage, "Girdi Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }

        internal void SetControls(MarsPackage result)
        {
            string coordinate = string.Concat(result.MoverInformation.MoverCoordinate);
            txtResult.Text = coordinate + " " +result.MoverInformation.MoverDirection.ToString();
            txtInputCopy.Text = txtInput.Text;
            txtInput.Clear();
        }

        internal void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
