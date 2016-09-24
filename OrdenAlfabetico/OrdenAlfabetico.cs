using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrdenAlfabetico
{
    public partial class OrdenAlfabetico : Form
    {
        public OrdenAlfabetico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lboxString.Items.Add(stringBox.Text);

        }

        List<string> s = new List<string>();

        private void sortBtn_Click(object sender, EventArgs e)
        {
            foreach (string i in lboxString.Items)
                s.Add(i);

            s.Sort();
            lboxString.Items.Clear();
            foreach (string i in s)
                lboxString.Items.Add(i);

        }
    }
}
