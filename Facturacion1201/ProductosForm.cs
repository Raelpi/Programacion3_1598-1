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
    public partial class Productos : Syncfusion.Windows.Forms.Office2010Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private string operacion = string.Empty;

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            CategoriacomboBox1.DataSource = bd.CargarCategorias();
            CategoriacomboBox1.DisplayMember = "DESCRIPCION";
            CategoriacomboBox1.ValueMember = "ID";

            ListarProductos();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            if(operacion == "Nuevo")
            {
                bd.InsertarProducto(txt_Codigo.Text, txt_Descripcion.Text, Convert.ToInt32(CategoriacomboBox1.SelectedValue), Convert.ToDecimal(txt_precio.Text), Convert.ToInt32(txt_Existencia.Text));
                ListarProductos();
                LimpiarControles();
            }
        }

        private void ListarProductos()
        {
            BaseDatos bd = new BaseDatos();
           ProductosdataGridView1.DataSource = bd.ListarProductos();
        }

        private void HabilitarControles()
        {
            txt_Codigo.Enabled = true;
            txt_Descripcion.Enabled = true;
            CategoriacomboBox1.Enabled = true;
            txt_precio.Enabled = true;
            txt_Existencia.Enabled = true;
        }

        private void LimpiarControles()
        {
            txt_Codigo.Clear();
            txt_Descripcion.Clear();
            txt_Existencia.Clear();
            txt_precio.Clear();
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoriacomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Existencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
