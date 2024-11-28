using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR._7._1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || string.IsNullOrEmpty(tbX2.Text))
            {
                tbY.Text = "Не введено даних!";
                return;
            }

            if (!double.TryParse(tbX1.Text, out double x1) || !double.TryParse(tbX2.Text, out double x2))
            {
                tbY.Text = "Некоректне значення!";
                return;
            }

            double y = Math.Sqrt(56 * x1 + (x1 + x2 + Math.Sin(x1 * x2)) / (5 - Math.Cos(Math.Pow(x2, 2))));


            tbY.Text = y.ToString("0.###");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbMinX.Text = string.Empty;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);

            if (x1 < x2)
                tbMinX.Text = x1.ToString();
            else if (x1 > x2)
                tbMinX.Text = x2.ToString();
            else
                tbMinX.Text = x1.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
