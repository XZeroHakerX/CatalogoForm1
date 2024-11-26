using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class Altavoz : PerifericoSalida
    {
        int alto;
     
   

        public Altavoz(TipoPeriferico tipo, int img, int idProducto, string marca, double precio, int rangoVolumen, string color, double decibelios, int alto, bool sonidoHq, bool tieneBotonApagado)
            : base( tipo, img, idProducto, marca, precio, rangoVolumen, color, decibelios)
        {
            Alto = alto;
            SonidoHq = sonidoHq;
            TieneBotonApagado = tieneBotonApagado;
        }   

        public int Alto {get{ return this.alto; } 
            set {
                if (value < 0) { throw new ArgumentException("Altura no puede ser menos de 0."); }
                else { this.alto = value; }
            } 
        }
        public bool SonidoHq { get; set;}
        public bool TieneBotonApagado {get; set;}

        public override string ToString()
        {
            return base.ToString() + $"Alto -> {Alto} cm // Sonido HQ? -> {SonidoHq} // Boton Apagado? -> {TieneBotonApagado}";
        }
    }
}
