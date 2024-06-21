namespace RestoBarClases
{
    public enum TipoDeMesa
    {
        Redonda,
        Cuadrada,
        Rectangular
    }

    public class Mesa
    {
        public int Id { get; set; }
        public decimal Consumo { get; set; }
        public TipoDeMesa Tipo { get; set; }
        public List<Silla> Sillas { get; set; }
        public bool Ocupada { get; set; }
        public bool Reservada { get; set; }
        public TimeSpan TiempoReserva { get; set; }

        public Mesa(int id, TipoDeMesa tipoDeMesa, int cantSillas)
        {
            Id = id;
            Tipo = tipoDeMesa;
            Sillas = new List<Silla>();
            for (int i = 1; i < cantSillas; i++)
            {
                Sillas.Add(new Silla(false));
            }
            Consumo = 0;
            Ocupada = false;
            Reservada = false;
        }

        public void OcuparSilla()
        {
            foreach (Silla silla in Sillas)
            {
                if (!silla.Ocupada)
                {
                    silla.Ocupada = true;
                    break;
                }
            }
        }
    }
}