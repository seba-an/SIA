using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utemAppWF
{
    public class Laboratorio
    {
        public int ID { get; set; }
        public string Sala { get; set; }
        public int Capacidad { get; set; }
        public string Hora { get; set; }
        public bool Disponibilidad { get; set; }

    }
}
