using Catalogo.controller;
using Catalogo.model;

namespace Catalogo.view
{
    internal class Menu
    {
        private ControladorBD cbd;
        //public List<Periferico> lista_bd;

        public Menu()
        {
            cbd = ControladorBD.getControlador();
            IniciaMenu();
        }


        private void IniciaMenu()
        {
            int? opcion = null;
            while (opcion != 0)
            {
                opcion = null;
                Console.WriteLine("\n********** MENU: **********");
                Console.WriteLine("***************************");
                Console.WriteLine("\n1. Ver Productos.");
                Console.WriteLine("2. Agregar Productos.");
                Console.WriteLine("3. Borrar Productos.");
                Console.WriteLine("0. SALIR Y GUARDAR.");
                Console.WriteLine("\nQue podemos hacer por ti? ");
                while (opcion == null)
                {
                    try
                    {
                        opcion = Int32.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Introduce un numero que corresponda con la opcion.");
                        opcion = null;
                    }
                }

                


                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nSALIENDO . . . . ");
                        break;

                    case 1:
                        MenuVista();
                        break;

                    case 2:
                        MenuAgregar();
                        break;

                    case 3:
                        MenuBorrar();
                        break;

                    default:
                        Console.WriteLine("No es una opcion valida");
                        break;
                }

            }

        }

        private void MenuAgregar()
        {
            int? cont3 = null;
            while (cont3 != 0)
            {
                Console.WriteLine("\nQue quieres agregar?");
                Console.WriteLine("\n1. Raton.");
                Console.WriteLine("2. Teclado.");
                Console.WriteLine("3. Pantalla.");
                Console.WriteLine("4. Altavoz.");
                Console.WriteLine("\n0. ATRAS.");
                cont3 = Int32.Parse(Console.ReadLine());

                switch (cont3)
                {
                    case 0:

                        Console.WriteLine("Saliendo de agregar . . . ");
                        break;

                    case 1:

                        Console.WriteLine("Vamos a introducir un RATON:");
                        Console.WriteLine("\nIntroduce el Id: (Int)");
                        int id_raton = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce la Marca: (String)");
                        string marca_raton = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Precio: (Double)");
                        double precio_raton = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Numero de Botones: (Int)");
                        int botones_raton = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Tipo de Señal: (String)");
                        string señal_raton = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Voltaje: (Double)");
                        double voltaje_raton = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce los DPI: (Int)");
                        int dpi = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si es Hergonomico: (True/False)");
                        bool hergonomico = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si tiene Ruleta Central: (True/False)");
                        bool ruleta = Boolean.Parse(Console.ReadLine());


                        cbd.AgregarElemento(cont3, id_raton, marca_raton, precio_raton, botones_raton, señal_raton, voltaje_raton, dpi, hergonomico, ruleta);
                        break;

                    case 2:

                        Console.WriteLine("Vamos a introducir un TECLADO:");
                        Console.WriteLine("\nIntroduce el Id: (Int)");
                        int id_teclado = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce la Marca: (String)");
                        string marca_teclado = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Precio: (Double)");
                        double precio_teclado = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Numero de Botones: (Int)");
                        int botones_teclado = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Tipo de Señal: (String)");
                        string señal_teclado = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Voltaje: (Double)");
                        double voltaje_teclado = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Numero de Teclas Numericas: (Int)");
                        int numero_teclas_numerico = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si es Mecanico: (True/False)");
                        bool es_mecanico = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si tiene Teclado Numerico: (True/False)");
                        bool tiene_numerico = Boolean.Parse(Console.ReadLine());

                        cbd.AgregarElemento(cont3, id_teclado, marca_teclado, precio_teclado, botones_teclado, señal_teclado, voltaje_teclado, numero_teclas_numerico, es_mecanico, tiene_numerico);
                        break;

                    case 3:

                        Console.WriteLine("Vamos a introducir una PANTALLA:");
                        Console.WriteLine("\nIntroduce el Id: (Int)");
                        int id_pantalla = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce la Marca: (String)");
                        string marca_pantalla = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Precio: (Double)");
                        double precio_pantalla = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Rango Volumen: (Int)");
                        int rango_pantalla = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Color: (String)");
                        string color_pantalla = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Decibelios: (Double)");
                        double decibelios_pantalla = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce las Pulgadas: (Int)");
                        int pulgadas = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si Tiene Altavoz: (True/False)");
                        bool tiene_altavoz = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si es HD: (True/False)");
                        bool es_hd = Boolean.Parse(Console.ReadLine());

                        cbd.AgregarElemento(cont3, id_pantalla, marca_pantalla, precio_pantalla, rango_pantalla, color_pantalla, decibelios_pantalla, pulgadas, tiene_altavoz, es_hd);
                        break;

                    case 4:

                        Console.WriteLine("Vamos a introducir un ALTAVOZ:");
                        Console.WriteLine("\nIntroduce el Id: (Int)");
                        int id_altavoz = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce la Marca: (String)");
                        string marca_altavoz = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Precio: (Double)");
                        double precio_altavoz = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Rango Volumen: (Int)");
                        int rango_altavoz = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Color: (String)");
                        string color_altavoz = Console.ReadLine();
                        Console.WriteLine("\nIntroduce el Decibelios: (Double)");
                        double decibelios_altavoz = Double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce el Alto: (Int)");
                        int alto = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si tiene Sonido HQ: (True/False)");
                        bool tiene_hq = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nIntroduce si tiene Boton de Apagado: (True/False)");
                        bool tiene_boton = Boolean.Parse(Console.ReadLine());

                        cbd.AgregarElemento(cont3, id_altavoz, marca_altavoz, precio_altavoz, rango_altavoz, color_altavoz, decibelios_altavoz, alto, tiene_hq, tiene_boton);
                        break;

                    default:

                        Console.WriteLine("Opcion no valida.");
                        break;


                }
            }
        }

        private void MenuBorrar()
        {
            int cont_borrar = 0;

            foreach (Periferico a in cbd.VerBD())
            {
                Console.WriteLine($"{cont_borrar + 1}. {a.ToString()}\n");
                cont_borrar++;
            }

            Console.WriteLine("¿Cual quieres borrar? (0 para cancelar)");

            try
            {
                int num_borrar = Int32.Parse(Console.ReadLine());
                if (num_borrar != 0)
                {
                    cbd.BorrarElemento(num_borrar);
                    Console.WriteLine("\nHe borrado...");
                }
                else
                {
                    Console.WriteLine("\nNOO he borrado");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nNo se borró nada. E: " + e.Message.ToString());
            }
        }

        private void MenuVista()
        {
            int? opcion_vista = null;
            while (opcion_vista != 0)
            {
                opcion_vista = null;
                Console.WriteLine("\n********** VISTA PRODUCTOS: **********");
                Console.WriteLine("**************************************");
                Console.WriteLine("\n1. Productos SIN ORDENAR.");
                Console.WriteLine("2. Productos por orden natural.");
                Console.WriteLine("3. Productos por orden de columnas.");
                Console.WriteLine("4. Filtrar Productos.");
                Console.WriteLine("\n0. ATRAS.");
                Console.WriteLine("\nQue podemos hacer por ti? ");
                while (opcion_vista == null)
                {
                    try
                    {
                        opcion_vista = Int32.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Introduce un numero que corresponda con la opcion.");
                        opcion_vista = null;
                    }
                }

                Console.WriteLine();


                switch (opcion_vista)
                {
                    case 0:
                        Console.WriteLine("Saliendo de vistas . . . ");
                        break;

                    case 1:
                        foreach (Periferico a in cbd.VerBD())
                        {
                            Console.WriteLine(a.ToString());
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        foreach (Periferico a in cbd.OrdenarPorDefecto())
                        {
                            Console.WriteLine(a.ToString());
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Por que columna quieres ordenar?");
                        Console.WriteLine("\n1. Tipo de Producto.");
                        Console.WriteLine("2. ID Producto.");
                        Console.WriteLine("3. Marca.");
                        Console.WriteLine("4. Precio.");
                        Console.WriteLine("\n0. ATRAS.");
                        Console.WriteLine("\nOrdenar por:");

                        int opcion_ordenar = Int32.Parse(Console.ReadLine());
                        if (opcion_ordenar != 0)
                        {
                            foreach (Periferico a in cbd.OrdenarPorColumna(opcion_ordenar))
                            {
                                Console.WriteLine($"{a.ToString()}");
                                Console.WriteLine();

                            }
                        }
                        break;

                    case 4:


                        Console.WriteLine("Por que criterio quieres filtrar?");
                        Console.WriteLine("\n1. Filtrar por TIPO . . .");
                        Console.WriteLine("2. Filtrar por IDPRODUCTO . . .");
                        Console.WriteLine("3. Filtrar por MARCA . . .");
                        Console.WriteLine("4. Filtrar por PRECIO IGUAL . . .");
                        Console.WriteLine("5. Filtrar por PRECIO MAYOR . . .");
                        Console.WriteLine("6. Filtrar por PRECIO MENOR . . .");
                        Console.WriteLine("\n0. ATRAS.");
                        Console.WriteLine("\nFiltrar por:");

                        int opcion_filtrar = Int32.Parse(Console.ReadLine());
                        List<Periferico> lista_filtrada;
                        double precioFiltro;
                        string marcaFiltro;
                        int idProductoFiltro;
                        int tipoFiltro;
                        if (opcion_filtrar != 0)
                        {
                            switch (opcion_filtrar)
                            {
                                case 1:
                                    Console.WriteLine("\nIntroduce un tipo: (0.Raton, 1.Teclado, 2.Pantalla, 3.Altavoz)");
                                    tipoFiltro = Int32.Parse(Console.ReadLine());
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar, tipoFiltro, null, null, null);
                                    break;
                                case 2:
                                    Console.WriteLine("\nIntroduce un IdProducto: (Integer)");
                                    idProductoFiltro = Int32.Parse(Console.ReadLine());
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar, null, idProductoFiltro, null, null);
                                    break;
                                case 3:
                                    Console.WriteLine("\nIntroduce una marca: (String)");
                                    marcaFiltro = Console.ReadLine().Trim();
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar, null, null, marcaFiltro, null);
                                    break;
                                case 4:

                                    Console.WriteLine("\nIntroduce un precio para buscar precios iguales: (Double)");
                                    precioFiltro = Double.Parse(Console.ReadLine());
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar, null, null, null, precioFiltro);
                                    break;

                                case 5:

                                    Console.WriteLine("\nIntroduce un precio para buscar precios mayores: (Double)");
                                    precioFiltro = Double.Parse(Console.ReadLine());
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar, null, null, null, precioFiltro);
                                    break;

                                case 6:

                                    Console.WriteLine("\nIntroduce un precio para buscar precios menores: (Double)");
                                    precioFiltro = Double.Parse(Console.ReadLine());
                                    lista_filtrada = cbd.FiltrarProductoPrecio(opcion_filtrar,null,null,null, precioFiltro);
                                    
                                    break;

                                default:

                                    lista_filtrada = new List<Periferico>();
                                    break;
                            }
                            
                           
                            for (int i = 0; i < lista_filtrada.Count; i++)
                            {

                                Console.WriteLine($"\n{i+1}. {lista_filtrada[i].ToString()}");
                                Console.WriteLine();
                            }


                            if(lista_filtrada.Count == 1) 
                            {
                                Console.WriteLine("\nModificar o Borrar Articulo? (True / False)");
                                bool repuesta = Boolean.Parse(Console.ReadLine());
                                    if (repuesta)
                                    {
                                        Console.WriteLine("\n1. Modificar TIPO.");
                                        Console.WriteLine("2. Modificar IDPRODUCTO.");
                                        Console.WriteLine("3. Modificar MARCA.");
                                        Console.WriteLine("4. Modificar PRECIO.");
                                        Console.WriteLine("\n5. BORRAR.");

                                        int opcion_update = Int32.Parse(Console.ReadLine());
                                        switch (opcion_update)
                                        {

                                        case 1:
                                            Console.WriteLine("\nTipo NUEVO: (0.Raton, 1.Teclado, 2.Pantalla, 3.Altavoz)");
                                            int tipo_nuevo = Int32.Parse(Console.ReadLine());
                                            cbd.ModificarTipo(lista_filtrada[0], (TipoPeriferico) tipo_nuevo);
                                            break;
                                        
                                        case 2:
                                            Console.WriteLine("\nIdProducto NUEVO: (Integer)");
                                            int idProducto_nuevo = Int32.Parse(Console.ReadLine());
                                            cbd.ModificarIdProducto(lista_filtrada[0], idProducto_nuevo);
                                            break;

                                        case 3:
                                            Console.WriteLine("\nMarca NUEVA: (String)");
                                            string marca_nueva = Console.ReadLine().Trim();
                                            cbd.ModificarMarca(lista_filtrada[0], marca_nueva);
                                            break;

                                        case 4:

                                            Console.WriteLine("\nPrecio NUEVO: (Double)");
                                            double precio_nuevo = Double.Parse(Console.ReadLine());
                                            cbd.ModificarPrecio(lista_filtrada[0], precio_nuevo);
                                            break;

                                        case 5:
                                            cbd.BorrarElemento(lista_filtrada[0]);
                                            break;

                                        default:

                                            break;

                                    }
                                }
                            }

                        }
                        
                        break;

                
                }

            }
        }
    }
}
