using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_Repaso_2
{
    internal class Resumen : Vehiculos
    {
        string nombre;
        DateTime fechaDevolucion;
        double totalpagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public double Totalpagar { get => totalpagar; set => totalpagar = value; }
    }
}
