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
    public partial class frmsecundario : Form
    {
        public frmsecundario()
        {
            InitializeComponent();
        }

        private void txttexto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblusuario.Text = txtUsuario.Text;
        }

        private void frmsecundario_Load(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
