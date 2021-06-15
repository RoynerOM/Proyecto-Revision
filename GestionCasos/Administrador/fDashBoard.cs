using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasos
{
    public partial class fDashBoard : Form
    {
        public fDashBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
