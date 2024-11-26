using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class PerifericoSalida: Periferico
    {
        int rangoVolumen;
        
        double decibelios;

        internal PerifericoSalida(TipoPeriferico tipo, int img, int idProducto, string marca, double precio, int rangoVolumen, string color, double decibelios)
            : base(tipo, img, idProducto, marca, precio) 
        {
            RangoVolumen = rangoVolumen;
            Color = color;
            Decibelios = decibelios;
        }
        public int RangoVolumen { get { return this.rangoVolumen; } set {
                if (value < 0) { throw new ArgumentException("Rango de volumen no puede ser menos de 0."); }
                else { this.rangoVolumen = value; }
            } }
        public string Color { get; set; }

        public double Decibelios { get { return this.decibelios; } set
            {
                if (value < 0.0) { throw new ArgumentException("Decibelios no puede ser menos de 0."); }
                else { this.decibelios = value; }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"RangoVolumen -> {RangoVolumen} // Color -> {Color} // Decibelos -> {Decibelios} // ";
        }
    }




    
}
