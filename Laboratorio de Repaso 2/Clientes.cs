﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_de_Repaso_2
{
    internal class Clientes
    {
        int nit;
        string nombre;
        string direccion;

        public int Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
