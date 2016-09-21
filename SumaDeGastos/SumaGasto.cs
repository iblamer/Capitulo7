using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SumaDeGastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<int> gasto = new Stack<int>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            gasto.Push(int.Parse(gastosTBox.Text));

            gastosLBox.Items.Add(gastosTBox.Text);

            foreach (int g in gasto)
            {
                sumBox.Text = gasto.Sum().ToString();
            }
            
        }
    }
}
