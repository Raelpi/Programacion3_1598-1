﻿using System;
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

            txt_informacion.Text = persona.devolverNombreYNCuenta().ToString();

            promedio Notas = new promedio();

            Notas.Nota1 = Convert.ToInt32( txt_Nota1.Text);
            Notas.Nota2 = Convert.ToInt32(txt_Nota2.Text);
            Notas.Nota3 = Convert.ToInt32(txt_nota3.Text);
            Notas.Nota4 = Convert.ToInt32(txt_nota4.Text);
            Notas.calificacion = txt_califacion.Text;

            txtpromedioTotal.Text = Notas.devolverPromedio().ToString();

            int Informacion = Convert.ToInt32(txtpromedioTotal.Text);


        }
    }
}