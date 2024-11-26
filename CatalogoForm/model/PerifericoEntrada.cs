using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    internal class PerifericoEntrada: Periferico, ISoftwareEntrada
    {
        int numBotones;
        double voltaje;

        internal PerifericoEntrada(TipoPeriferico tipo,int img, int idProducto, string marca, double precio, int numBotones, string tipoSeñal, double voltaje) 
            : base(tipo, img, idProducto, marca, precio) 
        {
            NumBotones = numBotones;
            TipoSenal = tipoSeñal;
            Voltaje = voltaje;
        }

        public int NumBotones
        {
            get { return numBotones; }
            set {
                if (value < 0) { throw new ArgumentException("Numero de botones no puede ser menos de 0."); }
                else { this.numBotones = value; }
            }
        }
        public string TipoSenal { get; set; }
       
        public double Voltaje { 
            get { return voltaje; } 
            set {
                if (value < 0) { throw new ArgumentException("Voltaje no puede ser menos de 0."); }
                else { this.voltaje = value; } 
            }
        }

        public void descargaSoftwareEntrada()
        {
            Console.WriteLine("Descargando Software Entrada");
        }

        public override string ToString()
        {
            return base.ToString() + $"Numero Botones -> {NumBotones} // TipoSeñal -> {TipoSenal} // Voltaje -> {Voltaje}v // ";
        }
    }
}
