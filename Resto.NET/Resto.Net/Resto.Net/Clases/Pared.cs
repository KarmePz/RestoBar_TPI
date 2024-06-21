namespace RestoBarClases
{
    public class Pared : IEstructura
    {
        public double Longitud { get; set; }
        public double Ancho { get; set; }
        public List<Puerta> Puertas { get; set; }

        public Pared(double longitud, double ancho)
        {
            Longitud = longitud;
            Ancho = ancho;
            Puertas = new List<Puerta>();
        }

        public void AgregarPuerta(Puerta puerta)
        {
            throw new NotImplementedException();
        }

    }
}