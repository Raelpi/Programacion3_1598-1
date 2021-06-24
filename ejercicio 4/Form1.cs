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
        public void button2_Click(object sender, EventArgs e)
        {
            int[] valoresDesc = { comboBox1.SelectedIndex };

            valoresDesc = valoresDesc.OrderByDescending(c => c).ToArray();

            foreach (var item in valoresDesc)
            {
                comboBox2.Items.Add(item);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }
    }
}
