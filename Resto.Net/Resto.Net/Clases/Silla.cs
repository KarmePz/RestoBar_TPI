using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public class Silla
    {
        public bool Ocupada { get; set; }
        public bool Individual { get; set; }

        public Silla(bool individual)
        {
            Ocupada = false;
            Individual = individual;
        }
    }
}