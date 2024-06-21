namespace RestoBarClases
{

    //public class UserControl
    //{

    //}

    public class RestoBar
    {
        public string NombreRest { get; set; }

        //public List<UserControl> ListaControles { get; set; }
        public List<Mesa> Mesas { get; set; }
        public List<Silla> SillasIndividuales { get; set; }
        public List<Mozo> mozos { get; set; }

        public List<IEstructura> estructuras { get; set; }






        public RestoBar(string nombreRest /*List<UserControl> listaControles*/)
        {
            this.NombreRest = nombreRest;
            //ListaControles = listaControles;
        }
    }
}