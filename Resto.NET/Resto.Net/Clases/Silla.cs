using static Resto.Net.Preview;

namespace RestoBarClases
{
    public enum TipoDeSilla
    {
        TipoDefault,
        Tipo1,
        Tipo2,
        Tipo3,
        Tipo4,
        Tipo5,
        Tipo6,
        Tipo7
    }
    public class Silla
    {
        public int Id { get; set; }
        public TipoDeSilla TipoSilla { get; set; }
        public Dictionary<string, decimal> Consumo { get; set; }
        public Mozo MozoAsignado { get; set; }
        public Estado Estado { get; set; }
        public bool Individual { get; set; }

        public Silla(int id, TipoDeSilla tiposilla, bool individual)
        {
            Id = id;
            Estado = Estado.Libre;
            Individual = individual;
            TipoSilla = tiposilla;
            Consumo = new();

        }

    }
}