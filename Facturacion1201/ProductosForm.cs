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
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
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
            if(string.IsNullOrEmpty(txt_Codigo.Text))
            {
                errorProvider1.SetError(txt_Codigo, "Ingrese el codigo");
                txt_Codigo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_Descripcion.Text))
            {
                errorProvider1.SetError(txt_Descripcion, "Ingrese una descripcion");
                txt_Descripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_precio.Text))
            {
                errorProvider1.SetError(txt_precio, "Ingrese un precio");
                txt_precio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Existencia.Text))
            {
                errorProvider1.SetError(txt_Existencia, "Ingrese una existencia ");
                txt_Existencia.Focus();
                return;
            }
            BaseDatos bd = new BaseDatos();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImagenpictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            if(operacion == "Nuevo")
            {
                bd.InsertarProducto(txt_Codigo.Text, txt_Descripcion.Text, Convert.ToInt32(CategoriacomboBox1.SelectedValue), Convert.ToDecimal(txt_precio.Text), Convert.ToInt32(txt_Existencia.Text) ,  ms.GetBuffer());
                ListarProductos();
                LimpiarControles();
                DesabilitarControles();
            }
            else if (operacion == "Modificar")
            {
                bool modifico = bd.EditarProductos(txt_Codigo.Text, txt_Descripcion.Text, Convert.ToInt32(CategoriacomboBox1.SelectedValue), Convert.ToDecimal(txt_precio.Text), Convert.ToInt32(txt_Existencia.Text));
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
            btn_Cancelar.Enabled = true;
            btn_Guardar.Enabled = true;

            btn_modificar.Enabled = false;
            btn_nuevo.Enabled = false;

           
        }
        private void DesabilitarControles()
        {
            txt_Codigo.Enabled = false;
            txt_Descripcion.Enabled = false;
            CategoriacomboBox1.Enabled = false;
            txt_precio.Enabled = false;
            txt_Existencia.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;

            btn_modificar.Enabled = true;
            btn_nuevo.Enabled = true;
        }

        private void LimpiarControles()
        {
            txt_Codigo.Clear();
            txt_Descripcion.Clear();
            txt_Existencia.Clear();
            txt_precio.Clear();
            ImagenpictureBox1.Image = null;
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            BaseDatos bd = new BaseDatos();

            if(ProductosdataGridView1.SelectedRows.Count > 0)
            {
                txt_Codigo.Text = ProductosdataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
                txt_Descripcion.Text = ProductosdataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                CategoriacomboBox1.Text = ProductosdataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                txt_precio.Text = ProductosdataGridView1.CurrentRow.Cells["PRECIO"].Value.ToString();
                txt_Existencia.Text = ProductosdataGridView1.CurrentRow.Cells["EXISTENCIA"].Value.ToString();

                var temporal = bd.SeleccionarImagenProductos(ProductosdataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString());
             
                if (temporal.Length > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(temporal);
                    ImagenpictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                else
                {
                    ImagenpictureBox1.Image = null;
                }

                HabilitarControles();

            }
            else
            {
                MessageBox.Show("debe seleccionar una fila del producto");
            }

           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(ProductosdataGridView1.SelectedRows.Count > 0 )
            {
                BaseDatos bd = new BaseDatos();
                bool Elimine = bd.Eliminarproducto(ProductosdataGridView1.CurrentRow.Cells[0].Value.ToString());
                ListarProductos();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                ImagenpictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
         if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
         if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
