using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormatoNumerosNegativos
{
    public partial class FormatoNumerosNegativos : Form
    {
        public FormatoNumerosNegativos()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            resBox.Text = (double.Parse(num1Box.Text) + double.Parse(num2Box.Text)).ToString();

            if (double.Parse(resBox.Text) < 0)
                resBox.Text = String.Format("({0})", resBox.Text);
        }
    }
}
