namespace RestoBarClases
{
    internal class BotonMesa : Button
    {
        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1;

        public BotonMesa(Mesa claseMesa)
        {
            ClaseMesa = claseMesa;
            this.ContextMenuStrip = new ContextMenuStrip();
        }
    }
    internal class BotonSilla : Button
    {
        public static int StaticID { get; set; } = 0;
        public Silla claseSilla { get; private set; }
        public BotonSilla(Silla silla)
        {
            claseSilla = silla;
        }
    }

}
