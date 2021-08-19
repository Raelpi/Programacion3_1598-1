using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturacion1201
{
    public partial class Usuarios : Syncfusion.Windows.Forms.Office2010Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        String operacion = string.Empty;

        BaseDatos bd = new BaseDatos();

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            habilitarControles();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void habilitarControles()
        {
            txt_Codigo.Enabled = true;
            txt_Contraseña.Enabled = true;
            txt_Nombre.Enabled = true;
            checkBox1.Enabled = true;

            btn_Cancelar.Enabled = true;
            btn_Guardar.Enabled = true;

            btn_Modificar.Enabled = false;
            btn_Nuevo.Enabled = false;

        }

        private void DesabilitarControles()
        {
            txt_Codigo.Enabled = false;
            txt_Contraseña.Enabled = false;
            txt_Nombre.Enabled = false;
            checkBox1.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;

            btn_Modificar.Enabled = true;
            btn_Nuevo.Enabled = true;
        }

        private void LimpiarControles()
        {
            txt_Codigo.Clear();
            txt_Contraseña.Clear();
            txt_Nombre.Clear();
            checkBox1.Checked = false;
        }

        private void ListarUsuarios()
        {
            UsuariosdataGridView1.DataSource = bd.SeleccionarUsuarios();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(operacion == "Nuevo")
            {
                bool inserto = bd.InsertarUsuario(txt_Codigo.Text, txt_Contraseña.Text, txt_Nombre.Text);
                ListarUsuarios();
                LimpiarControles();
            }
            else if(operacion == "Modificar")
            {
                bool edito = bd.EditarUsuario(txt_Codigo.Text, txt_Contraseña.Text, txt_Nombre.Text, checkBox1.Checked);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";


            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                txt_Codigo.Text = UsuariosdataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
                txt_Nombre.Text = UsuariosdataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txt_Contraseña.Text = UsuariosdataGridView1.CurrentRow.Cells["CLAVE"].Value.ToString();
                checkBox1.Checked = Convert.ToBoolean( UsuariosdataGridView1.CurrentRow.Cells["ESTAACTIVO"].Value);
                habilitarControles();
                ListarUsuarios();

            }
            else
            {
                MessageBox.Show("debe seleccionar un usuario");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                BaseDatos bd = new BaseDatos();
                bool Elimino = bd.EliminarUsuario(UsuariosdataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString());
                ListarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Usuario");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
