using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTinyCalc
{
    /// <summary>
    /// Main calculator window
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Shown input 
        /// </summary>
        private TextBox InputStr { get; set; }

        /// <summary>
        /// Initialize the form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InputStr = new TextBox();

            InputStr.TextChanged += InputStr_TextChanged;
        }

        private void InputStr_TextChanged(object sender, EventArgs e)
        {
            Result.Text = ((TextBox)sender).Text ?? string.Empty;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputStr.Text = string.Empty;
            Result.Text = "0";
        }

        #region Digits input
        private void Input0Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "0";
        }

        private void Input1Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "1";
        }

        private void Input2Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "2";
        }

        private void Input3Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "3";
        }

        private void Input4Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "4";
        }

        private void Input5Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "5";
        }

        private void Input6Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "6";
        }

        private void Input7Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "7";
        }

        private void Input8Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "8";
        }

        private void Input9Btn_Click(object sender, EventArgs e)
        {
            InputStr.Text += "9";
        }
        #endregion
    }
}
