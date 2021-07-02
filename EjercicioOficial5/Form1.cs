using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioOficial5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Columnas.Clear();
            txt_filas.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int NFilas = Convert.ToInt32(txt_filas.Text);
            int NColumnas = Convert.ToInt32(txt_Columnas.Text);

            int[,] MatrizIndefinida = new int[NFilas,NColumnas];
            Random aleatorio = new Random();

            for(int filas = 0; filas < MatrizIndefinida.Length; filas++ )
            {
                for(int col = 0; col < MatrizIndefinida.Length; col++)
                {
                    MatrizIndefinida[filas, col] = aleatorio.Next(100);
                }

            }
            for (int filas = 0; filas < MatrizIndefinida.Length; filas++)
            {
                for (int col = 0; col < MatrizIndefinida.Length; col++)
                {
                    MessageBox.Show("la matriz es :" + MatrizIndefinida[filas, col].ToString());
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
