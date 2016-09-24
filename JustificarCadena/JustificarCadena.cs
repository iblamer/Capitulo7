using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JustificarCadena
{
    public partial class JustificarCadena : Form
    {
        public JustificarCadena()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (lineCheck.Checked == true)
            {
                string[] w = stringBox.Text.Split(' ');
                foreach (string word in w)
                    lboxString.Items.Add(word);
            }

            if (spaceCheck.Checked == true)
            {
                string w = stringBox.Text.Replace(" ", string.Empty);
                lboxString.Items.Add(w);
            }

            if(guionCheck.Checked == true)
            {
                string w = stringBox.Text.Replace(" ", "-");
                lboxString.Items.Add(w);
            }

            if(slashCheck.Checked == true)
            {
                string w = stringBox.Text.Replace(" ", "/");
                lboxString.Items.Add(w);
            }


        }
    }
}
