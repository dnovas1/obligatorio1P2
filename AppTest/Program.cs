using Dominio;
using Dominio.Entidades;
using System.Xml;
using static Dominio.Sistema;

namespace AppTest
{
    internal class Program
    {
        static Sistema _sistema = new Sistema();

        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.Clear();
                    MostrarTitulo("Menu");
                    opcion = PedirNumero(

                        "1- Precargar datos\n" +
                        "2- Ver listado de todos los clientes\n" +
                        "3- Listar artículos por categoría\n" +
                        "4- Alta artículo\n" +
                        "5- Listar publicaciones entre fechas\n" +
                        "0-salir\n" +
                        "Ingrese la opción:");

                    switch (opcion)
                    {
                        case 1:
                            PrecargarDatos();
                            break;
                        case 2:
                            VerListadoClientes();
                            break;
                        case 3:
                            ListarArticulosPorCategoria();
                            break;
                        case 4:
                            AltaArticulo();
                            break;
                        case 5:
                            ListarPublicacionesEntreFechas();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    MostrarError(e.Message);
                    Console.ReadLine();
                }
            }
            while (opcion != 0);
        }

        private static void PrecargarDatos()
        {
            try
            {
                _sistema.PrecargarDatos();
                Console.WriteLine("La precarga se realizo correctamente.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                MostrarError(e.Message);
                Console.ReadLine();
            }
        }
        private static void VerListadoClientes()
        {
            try
            {
                // Obtener la lista de clientes
                List<Usuario> clientes = _sistema.VerListadoClientes();

                if (clientes.Count == 0)
                {
                    Console.WriteLine("La lista esta vacia.");
                }

                // Mostrar cada cliente directamente
                Console.Clear();
                Console.WriteLine("Listado de clientes:\n");
                foreach (Cliente item in clientes)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Presione enter para volver al menu.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                MostrarError(e.Message);
                Console.ReadLine();
            }
        }


        private static void ListarArticulosPorCategoria()
        {
            try
            {
                string categoria = PedirString("Ingrese la categoria que desea buscar: ");

                // Llamo al metodo para obtener la lista de articulos
                List<Articulo> articulosPorCategoria = _sistema.ListarArticulosPorCategoria(categoria);

                // Si la lista esta vacia tiramos exception
                if (articulosPorCategoria.Count == 0)
                {
                    Console.WriteLine($"No hay artículos en la categoría ingresada.");
                }
                else
                {
                    Console.WriteLine($"Artículos en la categoría '{categoria}':");
                    foreach (Articulo articulo in articulosPorCategoria)
                    {
                        Console.WriteLine($"- Nombre: {articulo.NombreArticulo},Categoria: {articulo.Categoria} ,Precio: {articulo.Precio}");
                    }
                }
            }
            catch (Exception e)
            {
                MostrarError(e.Message);
            }
            Console.ReadLine();
        }

        private static void AltaArticulo()
        {
            try
            {
                string nombre = PedirString("Ingrese el nombre del artículo:");
                string categoria = PedirString("Ingrese la categoría del artículo:");
                decimal precio = PedirNumero("Ingrese el precio del artículo:");

                Articulo nuevoArticulo = new Articulo(nombre, categoria, precio);

                _sistema.AgregarArticulo(nuevoArticulo);
                Console.WriteLine("Artículo agregado exitosamente.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocurrió un error al agregar el artículo: {e.Message}");
                Console.ReadLine();
            }
        }

        private static void ListarPublicacionesEntreFechas()
        {
            try
            {
                Console.WriteLine("Ingrese la fecha de inicio (formato YYYY-MM-DD):");
                string fechaInicioIngresada = Console.ReadLine();
                DateTime fechaInicio;

                if (!DateTime.TryParse(fechaInicioIngresada, out fechaInicio))
                {
                    Console.WriteLine("El formato de la fecha de inicio ingresada es incorrecto. Intente nuevamente.");
                    Console.ReadLine();
                    return;
                }

                // Solicitar la segunda fecha y validarla
                Console.WriteLine("Ingrese la fecha de fin (formato YYYY-MM-DD):");
                string fechaFinIngresada = Console.ReadLine();
                DateTime fechaFin;

                if (!DateTime.TryParse(fechaFinIngresada, out fechaFin))
                {
                    Console.WriteLine("El formato de la fecha de fin ingresada es incorrecto. Vuelva a intentarlo.");
                    Console.ReadLine();
                    return;
                }

                //Llamo al metodo para obtener la lista de publicaciones entre mis dos fechas
                List<Publicacion> publicaciones = _sistema.ListarPublicacionesEntreFechas(fechaInicio, fechaFin);

                // Si no tengo publicaciones muestro mensaje
                if (publicaciones.Count == 0)
                {
                    Console.WriteLine("No hay publicaciones entre esas fechas.");
                }
                else
                {
                    Console.WriteLine($"Publicaciones entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}:");
                    foreach (Publicacion publicacion in publicaciones)
                    {
                        Console.WriteLine($"ID: {publicacion.IdPublicacion}, Nombre: {publicacion.NombrePublicacion}, Estado: {publicacion.Estado}, Fecha de Publicación: {publicacion.FechaPublicacion.ToShortDateString()}");
                    }
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }


        private static int PedirNumero(string mensaje)
        {
            int numero = 0;
            bool seguir = false;
            do
            {
                try
                {
                    Console.Write(mensaje);
                    numero = int.Parse(Console.ReadLine());
                    seguir = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo debe ingresar números.");
                    Console.ReadLine();
                    seguir = true;
                }
            } while (seguir);
            return numero;
        }

        private static string PedirString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        private static void MostrarTitulo(string mensaje)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine(mensaje);
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void MostrarError(string mensaje)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}