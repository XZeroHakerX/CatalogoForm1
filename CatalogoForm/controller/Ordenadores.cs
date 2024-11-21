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
            return y.IdProducto.CompareTo(x.IdProducto);
        }
    }
    public class OrdenarPorMarca() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return y.Marca.CompareTo(x.Marca);
        }
    }
    public class OrdenarPorPrecio() : IComparer<Periferico>
    {
        public int Compare(Periferico? x, Periferico? y)
        {
            return y.Precio.CompareTo(x.Precio);
        }
    }
}
