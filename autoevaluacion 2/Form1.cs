using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoevaluacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_NCuenta.Clear();
            txt_Nombre.Clear();
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_nota3.Clear();
            txt_nota4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario persona = new usuario();

            persona.NombreUsuario = txt_Nombre.Text;
            persona.NCuenta = Convert.ToInt32(txt_NCuenta.Text);

            MessageBox.Show(persona.devolverNombreYNCuenta());
        }
    }
}
