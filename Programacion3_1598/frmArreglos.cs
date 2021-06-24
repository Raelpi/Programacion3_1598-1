using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3_1598
{
    public partial class frmArreglos : Form
    {
        public frmArreglos()
        {
            InitializeComponent();
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            int[] edades = new int[5];
            edades[0] = 10;
            edades[1] = 20;
            edades[2] = 30;
            edades[3] = 40;
            edades[4] = 50;

            string[] paises = new string[] { "Honduras", "costa rica", "guatemala", "El salvador", "nicaragua" };

            for(int i=0; i< edades.Length; i++)
            {
                listboxArreglo.Items.Add(edades[i]);
            }



            foreach(var item in paises)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            //ordenar el arreglo
            int[] valores = { 3, 5, 1, 6, 9, 10, 15, 2 };

            //ordenar de menor a mayor
            //Array.Sort(valores);

            //Ordenar de mayor a menor 
           // Array.Reverse(valores);

            foreach (var item in valores)
            {
                OrdenarArreglo.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = { 3, 5, 1, 6, 9, 10, 15, 2 };

            int maximo = valores[0];
            int minimo = valores[0];

            for (int i = 1 ;i < valores.Length; i++)
                if(valores[i]>maximo)
                {
                    maximo = valores[i];
                }
                if(valores[i] < minimo)
            {
                minimo = valores[i];
            }

            MessageBox.Show("valor maximo: " + maximo + "valor Minimo:" + minimo);  
         }
   }
}