using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2Oficial
{
    public partial class LoginFormulario : Form
    {
        public LoginFormulario()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                errorProvider1.SetError(txt_Usuario, "ingrese el Usuario");
                txt_Usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_Usuario, "");

            if (txt_Contrasena.Text == "")
            {
                errorProvider1.SetError(txt_Contrasena, "ingrese el contraseña");
                txt_Contrasena.Focus();
                return;
            }
            errorProvider1.SetError(txt_Contrasena, "");




            if (txt_Usuario.Text == "rpineda" && txt_Contrasena.Text == "15/11/1998Gloria")
            {
                PedidosFarmacia Formulario = new PedidosFarmacia();
                this.Hide();
                Formulario.Show();

            }
            else
            {
                labelError.Visible = true;
            }
        }
    }
}
