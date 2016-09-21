using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class AgendaTelefonica : Form
    {
        public AgendaTelefonica()
        {
            InitializeComponent();
        }

        Dictionary<string, string> hash = new Dictionary<string, string>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            hash.Add(nameBox.Text, telBox.Text);
            if (String.IsNullOrEmpty(nameBox.Text) || String.IsNullOrEmpty(telBox.Text))
                MessageBox.Show("Ambos campos tienen que ser llenados");
            else
                agendaBox.Items.Add(String.Format("{0}\t\t\t{1}", nameBox.Text, telBox.Text));
            
        }
    }
}
