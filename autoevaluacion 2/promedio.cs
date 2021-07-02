using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoevaluacion_2
{
    class promedio
    {
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }
    public int Nota3 { get; set; }
    public int Nota4 { get; set; }

    public float TotalPromedio { get; set; }
    public int calificacion { get; set; }

        public promedio() { }

        public promedio(int _Nota1, int _Nota2,int _Nota3, int _Nota4,float _TotalPromedio,int _calificacion)
        {
            Nota1 = _Nota1;
            Nota2 = _Nota2;
            Nota3 = _Nota3;
            Nota4 = _Nota4;
            TotalPromedio = _TotalPromedio;
            calificacion = _calificacion;
        }
        public float devolverPromedio()
        {
            TotalPromedio = ((Nota1 + Nota2 + Nota3 + Nota4) / 4);
      
            return TotalPromedio;
        }

        public int devolverInfo()
        {
            calificacion = Convert.ToInt32(TotalPromedio);
            if(calificacion >=70)
            {
                Console.WriteLine("El alumno aprobo la clase");
            }else
            {
                Console.WriteLine("El alumno reprobo la clase");
            }
            return calificacion;
        }


    }
}
