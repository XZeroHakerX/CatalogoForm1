using Catalogo.model;
using System.Security.Cryptography.X509Certificates;


namespace Catalogo.controller
{

//Clase Utilidad para leer o escribir catalogo.dat
    public static class UtilidadesBD
    {

//Metodo para leer el archivo binario:
        public static List<Periferico> LeerBd(String ruta)
        {
            List<Periferico> lista = new List<Periferico>();
            string path = ruta;
            try
            {
                
                    
                    FileStream fs1 = File.Open(path, FileMode.OpenOrCreate, FileAccess.Read);
                    using (BinaryReader lectura = new BinaryReader(fs1))
                    {
                        while (lectura.BaseStream.Position < lectura.BaseStream.Length)
                        {
                        
                            int o0 = lectura.ReadInt32();

                            int o10 = lectura.ReadInt32();

                            int o1 = lectura.ReadInt32();

                            string o2 = lectura.ReadString().Trim();

                            double o3 = lectura.ReadDouble();

                            int o4 = lectura.ReadInt32();

                            string o5 = lectura.ReadString().Trim();

                            double o6 = lectura.ReadDouble();

                            int o7 = lectura.ReadInt32();

                            bool o8 = lectura.ReadBoolean();

                            bool o9 = lectura.ReadBoolean();

                            switch (o0)
                            {
                                case 0:
                                    lista.Add(new Raton((TipoPeriferico)o0, o10, o1, o2, o3, o4, o5, o6, o7, o8, o9));
                                    break;
                                case 1:
                                    lista.Add(new Teclado((TipoPeriferico)o0, o10, o1, o2, o3, o4, o5, o6, o7, o8, o9));
                                    break;
                                case 2:
                                    lista.Add(new Pantalla((TipoPeriferico)o0, o10, o1, o2, o3, o4, o5, o6, o7, o8, o9));
                                    break;
                                case 3:
                                    lista.Add(new Altavoz((TipoPeriferico)o0, o10, o1, o2, o3, o4, o5, o6, o7, o8, o9));
                                    break;
                                 default:
                                    break;
                            }
                        }


                    }
                
            }
            catch (EndOfStreamException e)
            {
                Console.WriteLine("Terminado de leer fichero." + e.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede leer BD." + ex.Message);
            }
             
            return lista;

        }



//Metodo que borra y crea de nuevo el catalogo.dat:
        public static void EscribirBd(List<Periferico> lista, string ruta)
        {
            try
            {
                int longitudString = 50;
                string path = ruta;
                if (File.Exists(path)){
                    File.Delete(path );

                    //Con este podemos renombrar y no borrar el archivo:
                    //File.Move(path, $" Copia {DateTime.Now.Ticks}");
                }
                FileStream fs2 = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write);
                
                using (BinaryWriter escritura = new BinaryWriter(fs2))
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Periferico p = lista[i];
                        int tipo = p.Tipo;

                        escritura.Write(p.Tipo);
                        escritura.Write(p.Img);
                        escritura.Write(p.IdProducto);
                        escritura.Write(p.Marca.PadRight(longitudString));
                        escritura.Write(p.Precio);

                        switch (tipo)
                        {
                            case 0:
                                {
                                    Raton r = (Raton)p;
                                    escritura.Write(r.NumBotones);
                                    escritura.Write(r.TipoSenal.PadRight(longitudString));
                                    escritura.Write(r.Voltaje);
                                    escritura.Write(r.Dpi);
                                    escritura.Write(r.Hergonomico);
                                    escritura.Write(r.RuletaCentral);
                                    break;
                                }

                            case 1:
                                {
                                    Teclado r = (Teclado)p;
                                    escritura.Write(r.NumBotones);
                                    escritura.Write(r.TipoSenal.PadRight(longitudString));
                                    escritura.Write(r.Voltaje);
                                    escritura.Write(r.NumTeclasNumerico);
                                    escritura.Write(r.EsMecanico);
                                    escritura.Write(r.TecladoNumerico);
                                    break;
                                }

                            case 2:
                                {
                                    Pantalla r = (Pantalla)p;
                                    escritura.Write(r.RangoVolumen);
                                    escritura.Write(r.Color.PadRight(longitudString));
                                    escritura.Write(r.Decibelios);
                                    escritura.Write(r.Pulgadas);
                                    escritura.Write(r.TieneAltavoces);
                                    escritura.Write(r.EsHd);
                                    break;
                                }
                            case 3:
                                {
                                    Altavoz r = (Altavoz)p;
                                    escritura.Write(r.RangoVolumen);
                                    escritura.Write(r.Color.PadRight(longitudString));
                                    escritura.Write(r.Decibelios);
                                    escritura.Write(r.Alto);
                                    escritura.Write(r.SonidoHq);
                                    escritura.Write(r.TieneBotonApagado);
                                    break;
                                }
                        }
                    }
                }
                
                fs2.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    
    }
}

