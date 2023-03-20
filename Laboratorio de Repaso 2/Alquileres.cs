using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_Repaso_2
{
    internal class Alquileres
    {
        string nit;
        string placa;
        DateTime fechaalquiler;
        DateTime fechadevolucion;
        int krecorridos;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fechaalquiler { get => fechaalquiler; set => fechaalquiler = value; }
        public DateTime Fechadevolucion { get => fechadevolucion; set => fechadevolucion = value; }
        public int Krecorridos { get => krecorridos; set => krecorridos = value; }
    }
}
