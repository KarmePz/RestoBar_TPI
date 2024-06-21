namespace RestoBarClases
{
    internal class BotonMesa : Button
    {
        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1;

        public BotonMesa(Mesa claseMesa)
        {
            ClaseMesa = claseMesa;
        }
    }
}
