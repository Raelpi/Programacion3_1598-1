using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnEjecucion_Click(object sender, EventArgs e)
        {
           

            string[] Nombre = { txt_nombre.Text };
            int[] Edad = { Convert.ToInt32(txt_edad.Text) };

            foreach (var item in Nombre)
            {
                comboBox1.Items.Add(item);
               
            }
            foreach (var item in Edad)
            {
                comboBox1.Items.Add(item);

            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_edad.Clear();
            txt_nombre.Clear();
            comboBox1.Items.Clear();
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Nombre = { txt_nombre.Text };
            int[] Edad = { Convert.ToInt32(txt_edad.Text) };

            Nombre = Nombre.OrderByDescending(c => c).ToArray();
            
            foreach (var item in Nombre)
            {
                comboBox1.Items.Add(item);
            }

            Edad = Edad.OrderByDescending(c => c).ToArray();

            foreach (var item in Edad)
            {
                comboBox1.Items.Add(item);
            }


        }
    }
}
