using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.model
{
    public enum TipoPeriferico
    {
        RATON = 0,
        TECLADO = 1,
        PANTALLA = 2,
        ALTAVOZ = 3
    }

    public class Periferico: IComparable<Periferico>
    {

        private int tipo;
        private double precio;

        internal Periferico(TipoPeriferico tipo, int idProducto, string marca, double precio)
        {
            Tipo = (int)tipo;
            IdProducto = idProducto;
            Marca = marca;
            Precio = precio;
        }

        public int IdProducto { get; set; }
        public string Marca { get; set; }
        public double Precio { get { return this.precio; }
            set {
                if (value < 0) { throw new ArgumentException("Precio no puede ser menos de 0."); }
                else { this.precio = value; };
            }
        }

        public int Tipo {  
            get{return this.tipo; } 
            set{ this.tipo = value; }
        }

        

        public override string ToString()
        {
            TipoPeriferico tipoPeriferico = (TipoPeriferico)Tipo;
            return $"{tipoPeriferico.ToString()} //ID-> { IdProducto } //Marca-> { Marca } //Precio-> { Precio } //";
        }

        
        public int CompareTo(Periferico? otro)
        {
            if(otro == null) return 1; 
            if(otro.Tipo == this.Tipo) return otro.IdProducto.CompareTo(this.IdProducto);
            return otro.Tipo.CompareTo(this.Tipo) ;
        
        }
    }
}
