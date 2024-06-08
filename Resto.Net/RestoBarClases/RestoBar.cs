using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    //TODO: BORRAR ESTA CLASE, SOLO ESTA ACA PARA QUE NO ME SALTE ERROR
    public class UserControl
    {
        
    }

    public class RestoBar
    {
        public string NombreRest { get; set; }
        public List<UserControl> ListaControles { get; set; }

        public RestoBar(string nombreRest, List<UserControl> listaControles)
        {
            NombreRest = nombreRest;
            ListaControles = listaControles;
        }
    }
}