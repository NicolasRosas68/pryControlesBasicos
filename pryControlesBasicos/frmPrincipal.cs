using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesBasicos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblejex_MouseMove(object sender, MouseEventArgs e)
        {
            lblejex.Text= e.X.ToString();
            lblejey.Text= e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblVienvenidos.Visible = true;

        }

        private void frmPrincipal_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void lblVienvenidos_MouseEnter(object sender, EventArgs e)
        {
            lblVienvenidos.Location = new Point(120);

        }

        private void lblVienvenidos_Click(object sender, EventArgs e)
        {

        }
    }
}
