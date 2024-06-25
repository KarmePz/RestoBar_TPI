namespace RestoBarClases
{
<<<<<<< HEAD:Resto.Net/Resto.Net/Clases/Silla.cs
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
        public bool Ocupada { get; set; }
        public bool Individual { get; set; }

        public Silla(int id, TipoDeSilla tiposilla, bool individual)
        {
            Id = id;
            Ocupada = false;
            Individual = individual;
            TipoSilla = tiposilla;

        }

=======
    public class Silla
    {
        public bool Ocupada { get; set; }
        public bool Individual { get; set; }

        public Silla(bool individual)
        {
            Ocupada = false;
            Individual = individual;
        }
>>>>>>> 1cecd87ccbb839c03e4c27064a164e6844569531:Resto.NET/Resto.Net/Clases/Silla.cs
    }
}