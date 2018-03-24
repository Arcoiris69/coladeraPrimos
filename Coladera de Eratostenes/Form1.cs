using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera_de_Eratostenes
{
    public partial class Form1 : Form
    {
        Identificador i;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDale_Click(object sender, EventArgs e)
        {
            i = new Identificador(int.Parse(txtVal.Text));
            i.llenar();
            txtPrimos.Text = i.primos();
        }
    }
}
