using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EjercicioOficial5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[,] Matriz;
        private void btn_Matriz_Click(object sender, EventArgs e)
        {
            int Nfilas = Convert.ToInt32(txt_Filas.Text);
            int Ncolumnas = Convert.ToInt32(txt_Columnas.Text);
            Matriz = new int[Nfilas, Ncolumnas];
            Random aleatorio = new Random();

            dgv_Matriz.ColumnCount = Ncolumnas;
            dgv_Matriz.RowCount = Nfilas;

            for(int fila = 0; fila<Nfilas;fila++)
            {
                for(int columna = 0; columna<Ncolumnas; columna++)
                {
                    Matriz[fila, columna] = aleatorio.Next(0, 100);
                }
            }

            for (int fila = 0; fila < Nfilas; fila++)
            {
                for (int columna = 0; columna < Ncolumnas; columna++)
                {
                    dgv_Matriz.Rows[fila].Cells[columna].Value = Matriz[fila, columna];
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Columnas.Clear();
            txt_Filas.Clear();
            dgv_Matriz.Columns.Clear();
        }
    }
}
