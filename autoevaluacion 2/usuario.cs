using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoevaluacion_2
{
    class usuario
    {
        public string NombreUsuario { get; set; }
        public int NCuenta { get; set; }
        //public string Nota1 { get; set; }
       // public string Nota2 { get; set; }
        //public string Nota3 { get; set; }
       // public string Nota4 { get; set; }

        public usuario(){}

        public usuario(String _nombre, int _Ncuenta) 
        {
            NombreUsuario = _nombre;
            NCuenta = _Ncuenta;
        }
        


        public string devolverNombreYNCuenta()
        {
            return NombreUsuario + " " + NCuenta;
        }

    }
}
