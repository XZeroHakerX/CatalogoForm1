

using Catalogo.model;
using System.Collections;
using System.Collections.Immutable;

namespace Catalogo.controller
{
    

    public class ControladorBD
    {
//Ruta archivo:
        internal string RUTA = "catalogo.dat";
        
//Lista privada con la que se trabaja:
        private List<Periferico> lista_bd = new List<Periferico>();

        private static ControladorBD unico;

//Constructor (Leemos datos del archivo):
        private ControladorBD()
        {
            lista_bd = UtilidadesBD.LeerBd(RUTA);
        }

//Escribir datos en el archivo:

        public static ControladorBD getControlador()
        {
            if(unico == null) unico = new ControladorBD();
            return unico;
        }

        internal void SobreescribirBD()
        {
            UtilidadesBD.EscribirBd(lista_bd, RUTA);
        }

 //Devuelve la lista sin ordenar
        internal List<Periferico> VerBD()
        {
            return lista_bd;
        }

//Devuelve la lista ordenada por defecto.
        internal List<Periferico> OrdenarPorDefecto()
        {
            List<Periferico> ordenada = lista_bd;
            ordenada.Sort();
            return ordenada;
        }

//Devuelve la lista ordenada por columna elegida:
        internal List<Periferico> OrdenarPorColumna(int opcion)
        {
            
            
                switch (opcion) 
                {

//Ordenado por TIPO:
                    case 1:
                        List<Periferico> ordenada_tipo = lista_bd;
                        ordenada_tipo.Sort(new OrdenarPorTipo());
                        return ordenada_tipo;
                        break;

//Ordenado por IDPRODUCTO:
                    case 2:
                        List<Periferico> ordenada_id = lista_bd;
                        ordenada_id.Sort(new OrdenarPorID());
                        return ordenada_id;
                        break;

//Ordenado por MARCA:
                    case 3:
                        List<Periferico> ordenada_marca = lista_bd;
                        ordenada_marca.Sort(new OrdenarPorMarca());
                        return ordenada_marca;
                        break;

 //Ordenado por PRECIO:
                    case 4:
                        List<Periferico> ordenada_precio = lista_bd;
                        ordenada_precio.Sort(new OrdenarPorPrecio());
                        return ordenada_precio;
                        break; 
                    default:
                        Console.WriteLine("No válido para ordenar...");
                        throw new ArgumentException();
                        break;
                } 
                    
        }


//Agrega elementos a la lista
        internal void AgregarElemento(int? cont3, int id, string marca, double precio, int a1, string a2, double a3, int a4, bool a5, bool a6)
        {
           
            
            if(cont3 == null)
            {
                throw new ArgumentNullException();
            }

            switch (cont3)
            {
                case 1:
                    
                    cont3--;
                    lista_bd.Add(new Raton((TipoPeriferico)cont3, id, marca, precio, a1, a2, a3, a4, a5, a6));
                    SobreescribirBD();
                    Console.WriteLine($"Añadido Raton con ID {id}");

                    break;
                
                case 2:
                    
                    cont3--;
                    lista_bd.Add(new Teclado((TipoPeriferico)cont3, id, marca, precio, a1, a2, a3, a4, a5, a6));
                    SobreescribirBD();
                    Console.WriteLine($"Añadido Teclado con ID {id}");

                    break;
               
                case 3:
                    
                    cont3--;
                    lista_bd.Add(new Pantalla((TipoPeriferico)cont3, id, marca, precio, a1, a2, a3, a4, a5, a6));
                    SobreescribirBD();
                    Console.WriteLine($"Añadido Pantalla con ID {id}");

                    break;
                
                case 4:
                    
                    cont3--;
                    lista_bd.Add(new Altavoz((TipoPeriferico)cont3, id, marca, precio, a1, a2, a3, a4, a5, a6));
                    SobreescribirBD();
                    Console.WriteLine($"Añadido Altavoz con ID {id}");

                    break;
            }
        }

//Borrar elementos lista por indice:
        internal void BorrarElemento(int num_borrar)
        {
            lista_bd.RemoveAt(num_borrar-1);
            SobreescribirBD();
        }

//Borrar elementos lista por objeto:
        internal void BorrarElemento(Periferico articulo_borrar)
        {
            lista_bd.Remove(articulo_borrar);
            SobreescribirBD();
        }


//Devuelve la lista filtrada segun eleccion del usuario:
        internal List<Periferico> FiltrarProductoPrecio(int opcion, int? tipo, int? idProducto, string? marca, double? precio)
        {
            switch (opcion)
            {
//Devuelve por TIPO igual:
                case 1:

                    return lista_bd.Where(p => p.Tipo == tipo).ToList() ;
                
//Devuelve por IDPRODUCTO igual:    
                case 2:

                    return lista_bd.Where(p => p.IdProducto == idProducto).ToList();

//Devuelve por MARCA igual:    
                case 3:

                    return lista_bd.Where(p => p.Marca.ToLower().Contains(marca.ToLower())).ToList();
                    
//Devuelve por PRECIO igual:
                case 4:
                    return lista_bd.Where(p => p.Precio == precio).ToList();

//Devuelve por PRECIO SUPERIOR:
                case 5:
                    return lista_bd.Where(p => p.Precio > precio).ToList();

//Devuelve por PRECIO INFERIOR:
                case 6:
                    return lista_bd.Where(p => p.Precio < precio).ToList();

                default:

                    throw new NotImplementedException();
            }
        }

//Modificar PRECIO del objeto pasado:
        internal void ModificarPrecio(Periferico periferico, double precio_nuevo)
        {
            lista_bd.Find(p => p ==  periferico).Precio = precio_nuevo;
            SobreescribirBD();
        }

//Modificar MARCA del objeto pasado:
        internal void ModificarMarca(Periferico periferico, string marca_nuevo)
        {
            lista_bd.Find(p => p == periferico).Marca = marca_nuevo;
            SobreescribirBD();
        }

//Modificar IDPRODUCTO del objeto pasado:
        internal void ModificarIdProducto(Periferico periferico, int id_nuevo)
        {
            lista_bd.Find(p => p == periferico).IdProducto = id_nuevo;
            SobreescribirBD();
        }

//Modificar TIPO del objeto pasado:
        internal void ModificarTipo(Periferico periferico, TipoPeriferico tipo_nuevo)
        {
            lista_bd.Find(p => p == periferico).Tipo = (int)tipo_nuevo;
            SobreescribirBD();
        }

    }

}

    

