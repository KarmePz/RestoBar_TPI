using static Resto.Net.Preview;

namespace RestoBarClases
{
    public enum TipoDeMesa
    {
        Redonda,
        Cuadrada,
        Rectangular,
        Especiales
    }

    public class Mesa
    {
        public int Id { get; set; }
        public Dictionary<string, decimal> Consumo { get; set; }
        public TipoDeMesa Tipo { get; set; }
        public List<Silla> Sillas { get; set; }
        public Mozo MozoAsignado { get; set; }
        public Estado Estado { get; set; }
        public TimeSpan TiempoReserva { get; set; }

        public Mesa(int id, TipoDeMesa tipoDeMesa, int cantSillas)
        {
            Id = id;
            Tipo = tipoDeMesa;
            Sillas = new List<Silla>();
            for (int i = 0; i < cantSillas; i++)
            {
                Sillas.Add(new Silla(id, TipoDeSilla.TipoDefault, false));
            }
            Consumo = new();
            
        }

        public void OcuparSilla()
        {
            foreach (Silla silla in Sillas)
            {
                if (silla.Estado == Estado.Libre)
                {
                    silla.Estado = Estado.Ocupada;
                    break;
                }
            }
        }
    }
}