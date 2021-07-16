using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class LoginFormulario : Syncfusion.Windows.Forms.Office2010Form
    {
        public LoginFormulario()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(txt_Usuario.Text == "")
            {
                errorProvider1.SetError(txt_Usuario, "ingrese el Usuario");
                txt_Usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_Usuario, "");

            if (txt_Contrasena.Text == "")
            {
                errorProvider1.SetError(txt_Contrasena, "ingrese el Usuario");
                txt_Contrasena.Focus();
                return;
            }
            errorProvider1.SetError(txt_Contrasena, "");

            


            if(txt_Usuario.Text == "rpineda" || txt_Contrasena.Text == "15/11/1998" || txt_Contrasena.Text == "Gloria")
            {
                PepidosFarmacia Formulario = new PepidosFarmacia();
                this.Hide();
                Formulario.Show();
                
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Contrasena.Clear();
            txt_Usuario.Clear();
        }
    }
}
