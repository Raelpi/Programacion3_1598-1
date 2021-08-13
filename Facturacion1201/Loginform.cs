using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturacion1201
{
    public partial class Loginform : Syncfusion.Windows.Forms.Office2010Form 
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "")
            {
                errorProvider1.SetError(txt_usuario, "Ingrese el Usuario");
                txt_usuario.Focus();
                return;
            }
            errorProvider1.SetError(txt_usuario, "");

            if(txt_contrasena.Text == "")
            {
                errorProvider1.SetError(txt_contrasena, "Ingrese la contraseña");
                txt_contrasena.Focus();
                return;
            }
            errorProvider1.SetError(txt_contrasena, "");

            //CONECTAR  a la base de datos

            BaseDatos _base = new BaseDatos();

            if(_base.validarUsuario(txt_usuario.Text, txt_contrasena.Text))
            {
                PrincipalForm formulario = new PrincipalForm();
                this.Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalida");
            }


            //PrincipalForm formulario = new PrincipalForm();
           // this.Hide();

            //formulario.Show();
        }
    }
}
