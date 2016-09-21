using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiccionarioHash
{
    public partial class Diccionario : Form
    {
        public Diccionario()
        {
            InitializeComponent();
        }

        Dictionary<string, string> hash = new Dictionary<string, string>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(descBox.Text))
                MessageBox.Show("Ambos campos tienen que ser llenados");
            else
            {
                hash.Add(nameBox.Text, descBox.Text);
                hashBox.Items.Add(String.Format("{0}\t\t\t{1}", data.Key, data.Value));
                
            }
            
        }

        private void hashBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
