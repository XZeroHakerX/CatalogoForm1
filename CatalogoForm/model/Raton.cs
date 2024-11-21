using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class Raton : PerifericoEntrada
    {
        private int dpi;
        

        public Raton(TipoPeriferico tipo, int idProducto, string marca, double precio, int numeroBotones, string tipoSeñal, double voltaje, int dpi, bool hergonomico, bool ruletaCentral) 
            : base(tipo, idProducto, marca, precio, numeroBotones, tipoSeñal, voltaje)
        {
            Dpi = dpi;
            Hergonomico = hergonomico;
            RuletaCentral = ruletaCentral;
        }

        public int Dpi
        {
            get { return this.dpi; }
            set {
                if (value < 0) { throw new ArgumentException("No puede ser menos de 0 dpi"); }
                else { this.dpi = value; } 
            }
        }
        public bool Hergonomico { get; set; }
        public bool RuletaCentral { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"DPI-> {Dpi} // Hergo -> {Hergonomico} // Ruleta Central? {RuletaCentral}";
        }


    } 
}

