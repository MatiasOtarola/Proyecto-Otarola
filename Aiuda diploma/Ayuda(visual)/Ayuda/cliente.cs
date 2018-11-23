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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Navegador\\Desktop\\Ayuda.chm", HelpNavigator.Topic, "Cliente%20ayuda.htm");
        }
    }
}
