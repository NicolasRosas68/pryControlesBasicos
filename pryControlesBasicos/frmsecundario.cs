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
            lblusuario.Text = txtusuario.Text;
        }

        private void frmsecundario_Load(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string TextoContatenar = "";


            if (chkMayo.Checked == true)
            {
                lblConsultar.Text = "mayo de 10"; TextoContatenar = TextoContatenar + " mayo de 10";
            }

            if (chkPicante.Checked == true)               
            {
                lblConsultar.Text = "picanteeee"; TextoContatenar = TextoContatenar + " picanteee";
            }

            if (chkSalsa.Checked == true)
            {
                lblConsultar.Text = "salsa loca"; TextoContatenar = TextoContatenar + " salsa loca";

            }
            lblConsultar.Text = TextoContatenar;
            lstLista.Items.Add(TextoContatenar);
            
        }
             

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConsultar.Text = lstLista.Text;
            lblConsultar.Text = lstLista.SelectedItem.ToString();

        }

        private void optAzul_CheckedChanged(object sender, EventArgs e)
        {
            txtusuario.ForeColor = Color.Blue;
           
        }

        private void optRojo_CheckedChanged(object sender, EventArgs e)
        {
            txtusuario.ForeColor= Color.Red;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            lblmostrar.Text = txtusuario.Text;  
        }
    }
}
