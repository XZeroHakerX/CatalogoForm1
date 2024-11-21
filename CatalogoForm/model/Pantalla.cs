using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class Pantalla : PerifericoSalida
    {
        int pulgadas;
        

        public Pantalla(TipoPeriferico tipo, int idProducto, string marca, double precio, int rangoVolumen, string color, double decibelios, int pulgadas, bool tieneAltavoces, bool esHd )
            : base(tipo, idProducto, marca, precio, rangoVolumen, color, decibelios)
        {
            Pulgadas = pulgadas;
            TieneAltavoces = tieneAltavoces;
            EsHd = esHd;
        }

        public int Pulgadas { 
            get { return this.pulgadas; } 
            set {
                if (value < 0) { throw new ArgumentException("Pulgadas no puede ser menos de 0."); }
                else { this.pulgadas = value; }
            } 
        
        }

        public bool TieneAltavoces { get; set; }

        public bool EsHd { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Pulgadas -> {Pulgadas} // Altavoces? -> {TieneAltavoces} // HD? -> {EsHd}";
        }

    }
}
