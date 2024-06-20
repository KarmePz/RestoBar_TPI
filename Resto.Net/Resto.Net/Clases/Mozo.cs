using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public class Mozo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Mesa> MesasACargo { get; set; }

        public Mozo(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            MesasACargo = new List<Mesa>();
        }
    }
}