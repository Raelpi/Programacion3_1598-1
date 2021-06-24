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

    }
}
