namespace RestoBarClases
{
    public class Puerta : IEstructura
    {
        public double Longitud { get; set; }
        public double Ancho { get; set; }

        public Puerta(double longitud, double ancho)
        {
            Longitud = longitud;
            Ancho = ancho;
        }
    }
}