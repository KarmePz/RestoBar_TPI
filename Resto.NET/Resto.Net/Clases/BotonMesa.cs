using RestoBarClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Resto.Net.Clases
{
    internal class BotonMesa : Button
    {

        public Mesa ClaseMesa { get; set; }
        public static int StaticID = 1;
        public Timer permanenciaTimer;
        public int TiempoTranscurrido {get; set; }
        public int GradoRotacion { get; set; }
        public BotonMesa(Mesa claseMesa, int gradoRotacion)
        {
            ClaseMesa = claseMesa;
            this.permanenciaTimer = new Timer();
            this.permanenciaTimer.Interval = 1000;
            this.ContextMenuStrip = new ContextMenuStrip();
            GradoRotacion = gradoRotacion;
        }
        
    }
    internal class BotonSilla : Button
    {
        public static int StaticID { get; set; } = 1;
        public Silla claseSilla { get; private set; }
        public Timer permanenciaTimer;
      
        public int TiempoTranscurrido { get; set; }
        public int GradoRotacion { get; set; }

        public BotonSilla(Silla silla, int gradoRotacion)
        {
            claseSilla = silla;
            this.permanenciaTimer = new Timer();
            this.permanenciaTimer.Interval = 1000;
            GradoRotacion = gradoRotacion;
        }
    }
}





