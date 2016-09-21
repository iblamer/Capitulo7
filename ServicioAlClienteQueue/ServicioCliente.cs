using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServicioAlClienteQueue
{
    public partial class ServicioCliente : Form
    {
        public ServicioCliente()
        {
            InitializeComponent();
        }


        Queue<string> client = new Queue<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            client.Enqueue(clientBox.Text);

            foreach (string s in client)
            {
                queueBox.Items.Add(s);
            }
            client.Dequeue();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            queueBox.Items.RemoveAt(0);

        }
    }
}
