﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utemAppWF
{
    public class Profesor
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
