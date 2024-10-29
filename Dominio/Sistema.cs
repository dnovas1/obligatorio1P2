using Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Sistema
    {
        #region Listas

        private List<Publicacion> _publicaciones = new List<Publicacion>();
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Oferta> _ofertas = new List<Oferta>();
        private List<Articulo> _articulos = new List<Articulo>();

        #endregion

        #region Propiedades de listas
        public List<Publicacion> Publicaciones
        {
            get { return _publicaciones; }
        }

        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
        }

        public List<Oferta> Ofertas
        {
            get { return _ofertas; }
        }

        public List<Articulo> Articulos
        {
            get { return _articulos; }
        }
        #endregion
        #region Constructor
        public Sistema()
        {
            //PrecargarDatos(); si queremos precargar los datos de una, sino lo dejo comentado y lo hacemos manual desde el menu.
        }
        #endregion
        #region Precargas
        public void PrecargarDatos()
        {
            //Van en este orden para evitar errores 
            PrecargarArticulos();
            PrecargarUsuarios();
            PrecargarPublicaciones();
        }
        private void PrecargarArticulos()
        {
            Articulo articulo1 = new Articulo("Pelota", "Deporte", 1000);
            Articulo articulo2 = new Articulo("Arco", "Deporte", 5000);
            Articulo articulo3 = new Articulo("Zapatos de futbol", "Deporte", 2500);
            Articulo articulo4 = new Articulo("Raqueta de tenis", "Deporte", 3000);
            Articulo articulo5 = new Articulo("Guantes de boxeo", "Deporte", 1500);
            Articulo articulo6 = new Articulo("Casco de ciclismo", "Deporte", 2200);
            Articulo articulo7 = new Articulo("Bicicleta de montaña", "Deporte", 15000);
            Articulo articulo8 = new Articulo("Pesas", "Deporte", 4000);
            Articulo articulo9 = new Articulo("Cinta de correr", "Deporte", 25000);
            Articulo articulo10 = new Articulo("Red de voleibol", "Deporte", 3500);
            Articulo articulo11 = new Articulo("Medias", "Ropa", 200);
            Articulo articulo12 = new Articulo("Short", "Ropa", 1200);
            Articulo articulo13 = new Articulo("Camiseta", "Ropa", 1000);
            Articulo articulo14 = new Articulo("Pantalón de jogging", "Ropa", 1500);
            Articulo articulo15 = new Articulo("Buzo", "Ropa", 1800);
            Articulo articulo16 = new Articulo("Zapatillas deportivas", "Ropa", 3000);
            Articulo articulo17 = new Articulo("Chaqueta impermeable", "Ropa", 2500);
            Articulo articulo18 = new Articulo("Guantes de lana", "Ropa", 600);
            Articulo articulo19 = new Articulo("Bufanda", "Ropa", 700);
            Articulo articulo20 = new Articulo("Gorra", "Ropa", 500);
            Articulo articulo21 = new Articulo("Teléfono móvil", "Tecnología", 30000);
            Articulo articulo22 = new Articulo("Laptop", "Tecnología", 50000);
            Articulo articulo23 = new Articulo("Tablet", "Tecnología", 15000);
            Articulo articulo24 = new Articulo("Cámara fotográfica", "Tecnología", 25000);
            Articulo articulo25 = new Articulo("Smartwatch", "Tecnología", 8000);
            Articulo articulo26 = new Articulo("Auriculares inalámbricos", "Tecnología", 4000);
            Articulo articulo27 = new Articulo("Parlante Bluetooth", "Tecnología", 3500);
            Articulo articulo28 = new Articulo("Cargador portátil", "Tecnología", 1200);
            Articulo articulo29 = new Articulo("Teclado mecánico", "Tecnología", 3000);
            Articulo articulo30 = new Articulo("Monitor 24 pulgadas", "Tecnología", 15000);
            Articulo articulo31 = new Articulo("Cafetera", "Hogar", 4000);
            Articulo articulo32 = new Articulo("Tostadora", "Hogar", 1500);
            Articulo articulo33 = new Articulo("Licuadora", "Hogar", 3500);
            Articulo articulo34 = new Articulo("Plancha", "Hogar", 2000);
            Articulo articulo35 = new Articulo("Aspiradora", "Hogar", 8000);
            Articulo articulo36 = new Articulo("Ventilador", "Hogar", 3000);
            Articulo articulo37 = new Articulo("Microondas", "Hogar", 6000);
            Articulo articulo38 = new Articulo("Refrigerador", "Hogar", 30000);
            Articulo articulo39 = new Articulo("Horno eléctrico", "Hogar", 5000);
            Articulo articulo40 = new Articulo("Cocina a gas", "Hogar", 20000);
            Articulo articulo41 = new Articulo("Consola de videojuegos", "Entretenimiento", 40000);
            Articulo articulo42 = new Articulo("Juego de mesa", "Entretenimiento", 1500);
            Articulo articulo43 = new Articulo("Cartas de poker", "Entretenimiento", 500);
            Articulo articulo44 = new Articulo("Puzzle", "Entretenimiento", 800);
            Articulo articulo45 = new Articulo("Set de pintura", "Entretenimiento", 2000);
            Articulo articulo46 = new Articulo("Bicicleta eléctrica", "Entretenimiento", 20000);
            Articulo articulo47 = new Articulo("Libro de ciencia ficción", "Entretenimiento", 1200);
            Articulo articulo48 = new Articulo("Patineta", "Entretenimiento", 5000);
            Articulo articulo49 = new Articulo("Silla gamer", "Entretenimiento", 12000);
            Articulo articulo50 = new Articulo("Drone", "Entretenimiento", 30000);

            // Agregar articulos al sistema
            AgregarArticulo(articulo1);
            AgregarArticulo(articulo2);
            AgregarArticulo(articulo3);
            AgregarArticulo(articulo4);
            AgregarArticulo(articulo5);
            AgregarArticulo(articulo6);
            AgregarArticulo(articulo7);
            AgregarArticulo(articulo8);
            AgregarArticulo(articulo9);
            AgregarArticulo(articulo10);
            AgregarArticulo(articulo11);
            AgregarArticulo(articulo12);
            AgregarArticulo(articulo13);
            AgregarArticulo(articulo14);
            AgregarArticulo(articulo15);
            AgregarArticulo(articulo16);
            AgregarArticulo(articulo17);
            AgregarArticulo(articulo18);
            AgregarArticulo(articulo19);
            AgregarArticulo(articulo20);
            AgregarArticulo(articulo21);
            AgregarArticulo(articulo22);
            AgregarArticulo(articulo23);
            AgregarArticulo(articulo24);
            AgregarArticulo(articulo25);
            AgregarArticulo(articulo26);
            AgregarArticulo(articulo27);
            AgregarArticulo(articulo28);
            AgregarArticulo(articulo29);
            AgregarArticulo(articulo30);
            AgregarArticulo(articulo31);
            AgregarArticulo(articulo32);
            AgregarArticulo(articulo33);
            AgregarArticulo(articulo34);
            AgregarArticulo(articulo35);
            AgregarArticulo(articulo36);
            AgregarArticulo(articulo37);
            AgregarArticulo(articulo38);
            AgregarArticulo(articulo39);
            AgregarArticulo(articulo40);
            AgregarArticulo(articulo41);
            AgregarArticulo(articulo42);
            AgregarArticulo(articulo43);
            AgregarArticulo(articulo44);
            AgregarArticulo(articulo45);
            AgregarArticulo(articulo46);
            AgregarArticulo(articulo47);
            AgregarArticulo(articulo48);
            AgregarArticulo(articulo49);
            AgregarArticulo(articulo50);
        }


        private void PrecargarPublicaciones()
        {
            Publicacion unaPublicacion = null;

            unaPublicacion = new Subasta("SubastaDePrueba1", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-01-01"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba2", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-09-10"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba3", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-02-20"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba4", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-03-14"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba5", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-06-05"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba6", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-11-02"), _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba7", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba8", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba9", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Subasta("SubastaDePrueba10", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos);
            AgregarPublicacion(unaPublicacion);


            unaPublicacion = new Venta("VentaDePrueba1", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-05-24"), _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba2", Publicacion.EstadoPublicacion.Abierta, DateTime.Parse("2024-07-08"), _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba3", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba4", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba5", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba6", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba7", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba8", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba9", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
            unaPublicacion = new Venta("VentaDePrueba10", Publicacion.EstadoPublicacion.Abierta, DateTime.Now, _articulos, true);
            AgregarPublicacion(unaPublicacion);
        }

        private void PrecargarUsuarios()
        {
            Usuario unUsuario = null;

            // Precargar 10 clientes sin errores
            unUsuario = new Cliente(1, "Juan", "Pérez", "juan.perez@mail.com", "password1", 10000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(2, "María", "López", "maria.lopez@mail.com", "password2", 8500);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(3, "Pedro", "Gómez", "pedro.gomez@mail.com", "password3", 7000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(4, "Lucía", "Martínez", "lucia.martinez@mail.com", "password4", 12000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(5, "Ana", "García", "ana.garcia@mail.com", "password5", 5000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(6, "Carlos", "Sánchez", "carlos.sanchez@mail.com", "password6", 9400);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(7, "Sofía", "Rodríguez", "sofia.rodriguez@mail.com", "password7", 15000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(8, "Javier", "Torres", "javier.torres@mail.com", "password8", 3000);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(9, "Laura", "Díaz", "laura.diaz@mail.com", "password9", 7800);
            AgregarUsuario(unUsuario);

            unUsuario = new Cliente(10, "Diego", "Muñoz", "diego.munoz@mail.com", "password10", 6800);
            AgregarUsuario(unUsuario);

            // Precargar 2 Administradores sin errores
            unUsuario = new Administrador("admin1", "admin", "admin1@gmail.com", "adminpass1");
            AgregarUsuario(unUsuario);

            unUsuario = new Administrador("admin2", "admin2", "admin2@gmail.com", "adminpass2");
            AgregarUsuario(unUsuario);


            //// Precargar clientes con errores
            //unUsuario = new Cliente(1, "", "Pérez", "juan.perez@mail.com", "password1", 10000); --->El nombre del usuario no puede estar vacio.
            //AgregarUsuario(unUsuario);

            //unUsuario = new Cliente(1, "Juan", "", "juan.perez@mail.com", "password1", 10000); --->El apellido del usuario no puede estar vacio.
            //AgregarUsuario(unUsuario);
            
            //unUsuario = new Cliente(1, "Juan", "Pérez", "", "password1", 10000); --->El mail del usuario no puede estar vacio.
            //AgregarUsuario(unUsuario);
        }

        #endregion
        private void AgregarPublicacion(Publicacion venta)
        {
            if (venta == null)
            {
                throw new Exception("La publicacion no puede ser nula.");
            }
            // Validar el usuario antes de agregarlo
            venta.Validar();
            _publicaciones.Add(venta);
        }
        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("El usuario no puede ser nulo.");
            }
            // Validar el usuario antes de agregarlo
            usuario.Validar();
            _usuarios.Add(usuario);
        }

        public void AgregarArticulo(Articulo articulo)
        {
            if (articulo == null)
            {
                throw new Exception("No se recibieron los valores del artículo.");
            }
            if (_articulos.Contains(articulo)) 
            {
                throw new Exception($"El articulo con nombre '{articulo.NombreArticulo}' ya existe.");
            }
            // Validar articulo Y agrega el articulo a la lista si pasa la validacion
            articulo.Validar();
            _articulos.Add(articulo);
        }

        public List<Usuario> VerListadoClientes()
        {
            List<Usuario> aux = new List<Usuario>();

            // Filtrar los usuarios que son clientes y los agrega a la lista
            foreach (Usuario item in _usuarios)
            {
                if (item is Cliente cliente)
                {
                    aux.Add(cliente);
                }
            }
            return aux; 
        }

        public List<Articulo> ListarArticulosPorCategoria(string categoria) 
        {
            List<Articulo> _articulosPorCategoria = new List<Articulo>();

            string categoriaBuscada = categoria.ToLower();

            foreach (Articulo articulo in _articulos)
            {
                if (articulo.Categoria.ToLower() == categoriaBuscada)
                {
                    _articulosPorCategoria.Add(articulo);
                }
            }
            return _articulosPorCategoria;
        }

        public List<Publicacion> ListarPublicacionesEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Publicacion> publicacionesEntreFechas = new List<Publicacion>();

            // Filtramos las publicaciones que están entre las fechas indicadas
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.FechaPublicacion >= fechaInicio && publicacion.FechaPublicacion <= fechaFin)
                {
                    publicacionesEntreFechas.Add(publicacion);
                }
            }

            return publicacionesEntreFechas;
        }
    }
}

