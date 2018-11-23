using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuda
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAiuda_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            c.MdiParent = this;
            c.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Navegador\\Desktop\\Ayuda.chm", HelpNavigator.Topic, "Proveedor%20ayuda.htm");
        }
    }
}
