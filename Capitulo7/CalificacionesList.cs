using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo7
{
    public partial class CalificacionesList : Form
    {
        public CalificacionesList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(califBox.Text));
            listBox.Items.Add(califBox.Text);
            foreach (int n in list)
            {
                maxBox.Text = list.Max().ToString();
                minBox.Text = list.Min().ToString();
                promBox.Text = list.Average().ToString();
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
