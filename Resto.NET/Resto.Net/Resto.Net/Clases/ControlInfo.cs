namespace RestoBarClases
{
    public class ControlInfo
    {
        public string NombreTipo { get; set; }
        public Point UbicacionXY { get; set; }

        public ControlInfo(string nombreTipo, Point ubicacionXY)
        {
            NombreTipo = nombreTipo;
            UbicacionXY = ubicacionXY;
        }
    }
}