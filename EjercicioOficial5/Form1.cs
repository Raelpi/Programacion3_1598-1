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


            //  MatrizIndefinida[0, 0] = aleatorio.Next(0, 100);
            //  MatrizIndefinida[0, 1] = aleatorio.Next(0, 100);
            //  MatrizIndefinida[0, 2] = aleatorio.Next(0, 100);
            // MatrizIndefinida[0, 3] = aleatorio.Next(0, 100);
            // MatrizIndefinida[0, 4] = aleatorio.Next(0, 100);
            //  MatrizIndefinida[1, 0] = aleatorio.Next(0, 100);
            // MatrizIndefinida[1, 1] = aleatorio.Next(0, 100);
            // MatrizIndefinida[1, 2] = aleatorio.Next(0, 100);
            // MatrizIndefinida[1, 3] = aleatorio.Next(0, 100);
            // MatrizIndefinida[1, 4] = aleatorio.Next(0, 100);
            // MatrizIndefinida[2, 0] = aleatorio.Next(0, 100);
            // MatrizIndefinida[2, 1] = aleatorio.Next(0, 100);
            // MatrizIndefinida[2, 2] = aleatorio.Next(0, 100);
            // MatrizIndefinida[2, 3] = aleatorio.Next(0, 100);
            // MatrizIndefinida[2, 4] = aleatorio.Next(0, 100);
            //MatrizIndefinida[3, 0] = aleatorio.Next(0, 100);
            // MatrizIndefinida[3, 1] = aleatorio.Next(0, 100);
            //MatrizIndefinida[3, 2] = aleatorio.Next(0, 100);
            //MatrizIndefinida[3, 3] = aleatorio.Next(0, 100);
            // MatrizIndefinida[3, 4] = aleatorio.Next(0, 100);
            // MatrizIndefinida[4, 0] = aleatorio.Next(0, 100);
            // MatrizIndefinida[4, 1] = aleatorio.Next(0, 100);
            //MatrizIndefinida[4, 2] = aleatorio.Next(0, 100);
            // MatrizIndefinida[4, 3] = aleatorio.Next(0, 100);
            // MatrizIndefinida[4, 4] = aleatorio.Next(0, 100);

            //int NFilas = Convert.ToInt32(txt_filas.Text);
            //int NColumnas = Convert.ToInt32(txt_Columnas.Text);

            /* int[,] MatrizIndefinida = new int[Convert.ToInt32(txt_filas.Text),Convert.ToInt32(txt_Columnas.Text)];
             Random aleatorio = new Random();

             for (int filas = 0; filas < MatrizIndefinida.Length; filas++ )
             {
                 for(int col = 0; col < MatrizIndefinida.Length; col++)
                 {
                     MatrizIndefinida[filas, col] = aleatorio.Next();
                 }

             }
             for (int filas = 0; filas < MatrizIndefinida.Length; filas++)
             {
                 for (int col = 0; col < MatrizIndefinida.Length; col++)
                 {
                     Console.WriteLine(MatrizIndefinida[filas, col]);
                 }
                 Console.ReadKey();*/
            int filas = Convert.ToInt32(txt_filas.Text);
            int columnas = Convert.ToInt32(txt_Columnas.Text);
            Random aleatorio = new Random();

            for(int i = 0; i <filas; i++)
            {
                for(int j = 0;j<columnas;j++)
                {
                    listBox1.Items.Add(aleatorio.Next(10, 101));
                }
            }

            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

  
    }
}
