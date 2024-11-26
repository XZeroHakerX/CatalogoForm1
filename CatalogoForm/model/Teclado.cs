using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class Teclado : PerifericoEntrada
    {
        private int numTeclasNumerico;

        public Teclado(TipoPeriferico tipo, int img, int idProducto, string marca, double precio, int numeroBotones, string tipoSeñal, double voltaje, int numTeclasNumerico, bool esMecanico, bool tecladoNumerico)
            : base(  tipo, img, idProducto, marca, precio, numeroBotones, tipoSeñal, voltaje)
        {
            NumTeclasNumerico = numTeclasNumerico;
            EsMecanico = esMecanico;
            TecladoNumerico = tecladoNumerico;
        }

        public int NumTeclasNumerico { 
            get{return this.numTeclasNumerico; } 
            set{
                if (value < 0) { throw new ArgumentException("No puede ser menos de 0 dpi"); }
                else { this.numTeclasNumerico = value; }
            } 
        }
        public bool EsMecanico { get; set; }
        public bool TecladoNumerico { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Mecanico ? -> {EsMecanico} // Teclado Numerico? {TecladoNumerico} // NumTeclasNume-> {NumTeclasNumerico}";
        }
    }
}
