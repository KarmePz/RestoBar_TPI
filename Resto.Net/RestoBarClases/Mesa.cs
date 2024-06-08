using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoBarClases
{
    public enum TipoDeMesa
    {
        Redonda1 = 11, Redonda2 = 12, Redonda3 = 13, 
        Redonda4 = 14, Redonda5 = 15, Redonda6 = 16, 
        Cuadrada1 = 21, Cuadrada2 = 22, 
        Rectangular1 = 31, Rectangular2 = 32, Rectangular3 = 33, 
        Rectangular4 = 34, Rectangular5 = 35, Rectangular6 = 36
    }

    //TODO: HACER QUE HEREDE DE USERCONTROL
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

            //TODO: Agregar la funcion para dibujar la mesa.
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