using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PalabraPorLinea
{
    public partial class PalabraPorLinea : Form
    {
        public PalabraPorLinea()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string[] w = stringBox.Text.Split(' ');
            foreach (string word in w)         
                lboxString.Items.Add(word);

        }
    }
}
