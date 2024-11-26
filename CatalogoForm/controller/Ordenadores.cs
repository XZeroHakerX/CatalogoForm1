using Catalogo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.controller
{
    public class OrdenarPorTipo() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return y.Tipo.CompareTo(x.Tipo);
        }
    }
    public class OrdenarPorID() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return x.IdProducto.CompareTo(y.IdProducto);
        }
    }
    public class OrdenarPorMarca() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return x.Marca.CompareTo(y.Marca);
        }
    }
    public class OrdenarPorPrecio() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return x.Precio.CompareTo(y.Precio);
        }
    }
}
