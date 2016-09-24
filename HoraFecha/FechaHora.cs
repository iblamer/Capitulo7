using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoraFecha
{
    public partial class FechaHora : Form
    {
        public FechaHora()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            String format = String.Format("{0:H:m tt yyyy/d/MMMM }", DateTime.Now);

            dateBox.Items.Add(format);
        }
    }
}
