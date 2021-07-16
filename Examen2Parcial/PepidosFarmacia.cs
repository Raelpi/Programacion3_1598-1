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
    public partial class PepidosFarmacia : Syncfusion.Windows.Forms.Office2010Form
    {
        public PepidosFarmacia()
        {
            InitializeComponent();
        }

        private void PepidosFarmacia_Shown(object sender, EventArgs e)
        {
             
            
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Cantidad.Clear();
            txt_Direccion.Clear();
          
            txt_NombreCliente.Clear();
            txt_NombreMedicamento.Clear();
            txt_Precio.Clear();
            txt_Presentacion.Clear();
            txt_TipoMedicamento.Clear();
            txt_TotalAPagar.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Declaracion de variables
            // Datos Del pedido
            string NombreMedicamento = txt_NombreMedicamento.Text;
            string TipoMedicamento = txt_TipoMedicamento.Text;
            string Presentacion = txt_Presentacion.Text;
            int Cantidad = Convert.ToInt32(txt_Cantidad.Text);
            int Precio = Convert.ToInt32(txt_Precio.Text);
           
           
            //Datos del cliente
            string NombreCliente = txt_NombreCliente.Text;
            string Direccion = txt_Direccion.Text;
           //NombreMedicamento
            if(txt_NombreMedicamento.Text == "")
            {
                errorProvider1.SetError(txt_NombreMedicamento, "ingrese el Nombre Del Medicamento");
                txt_NombreMedicamento.Focus();
                return;
            }
            errorProvider1.SetError(txt_NombreMedicamento, "");
            //Tipo de medicamento
            if (txt_TipoMedicamento.Text == "")
            {
                errorProvider1.SetError(txt_TipoMedicamento, "ingrese el Tipo De Medicamento");
                txt_TipoMedicamento.Focus();
                return;
            }
            errorProvider1.SetError(txt_TipoMedicamento, "");
            //Presentacion
            if (txt_Presentacion.Text == "")
            {
                errorProvider1.SetError(txt_Presentacion, "ingrese la Presentacion");
                txt_Presentacion.Focus();
                return;
            }
            errorProvider1.SetError(txt_Presentacion, "");
            //cantidad
            if (txt_Cantidad.Text == "")
            {
                errorProvider1.SetError(txt_Cantidad, "ingrese la cantidad");
                txt_Cantidad.Focus();
                return;
            }
            errorProvider1.SetError(txt_Cantidad, "");
            //precio
            if (txt_Precio.Text == "")
            {
                errorProvider1.SetError(txt_Precio, "ingrese el precio");
                txt_Precio.Focus();
                return;
            }
            errorProvider1.SetError(txt_Precio, "");
          
            //Nombre Del Cliente
            if (txt_NombreCliente.Text == "")
            {
                errorProvider1.SetError(txt_NombreCliente, "ingrese el Nombre Del Cliente");
                txt_NombreCliente.Focus();
                return;
            }
            errorProvider1.SetError(txt_NombreCliente, "");
            //Direccion del Cliente
            if (txt_Direccion.Text == "")
            {
                errorProvider1.SetError(txt_Direccion, "ingrese la Direccion del cliente");
                txt_Direccion.Focus();
                return;
            }
            errorProvider1.SetError(txt_Direccion, "");

            int TotalaPagar = Cantidad * Precio;
            txt_TotalAPagar.Text = TotalaPagar.ToString();

            if (MessageBox.Show("Desea agregar los datos del sistema", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow Agregar = new DataGridViewRow();
                Agregar.CreateCells(dataGridView1);
                Agregar.Cells[0].Value = txt_NombreMedicamento.Text;
                Agregar.Cells[1].Value = txt_TipoMedicamento.Text;
                Agregar.Cells[2].Value = txt_Presentacion.Text;
                Agregar.Cells[3].Value = txt_Cantidad.Text;
                Agregar.Cells[4].Value = txt_Precio.Text;
                Agregar.Cells[5].Value = txt_TotalAPagar.Text;
                Agregar.Cells[6].Value = txt_NombreCliente.Text;
                Agregar.Cells[7].Value = txt_Direccion.Text;

                dataGridView1.Rows.Add(Agregar);
            }
          

           
        }

        private void PepidosFarmacia_Load(object sender, EventArgs e)
        {
            
        }
    }
}
