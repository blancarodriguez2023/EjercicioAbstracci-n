
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Producto
    {
        public double PrecioVenta { get; set; }
        public double CostoFabrica { get; set; }
        public string NombreProducto { get; set; }
        public string ColorPortada { get; set; }

        // Constructor
        public Producto(string nombre, string colorPortada, double precio, double costo)
        {
            NombreProducto = nombre;
            CostoFabrica = costo;
            PrecioVenta = precio;
            ColorPortada = colorPortada;
        }

        public abstract void ModificarDatos(string nombreProducto);
        public abstract string ConsultarDatos();
        public abstract string imprimirDatos();

        public class Libro : Producto
        {
            public Libro(string titulo, string colorPortada, double precio, double costo)
                : base(titulo, colorPortada, precio, costo)
            {

            }

            public override string ConsultarDatos()
            {
                return "Libro: " + NombreProducto + " colorPortada " + ColorPortada + ", Precio: " + PrecioVenta + ", costo " + CostoFabrica;
            }

            public override void ModificarDatos(string nombreProducto)
            {
                NombreProducto = nombreProducto;

            }

            public override string imprimirDatos()
            {
                return "Libro: " + NombreProducto + ", Precio: " + PrecioVenta;
            }
        }

        public class DVD : Producto
        {
            public DVD(string titulo, string colorPortada, double precio, double costo)
                : base(titulo, colorPortada, precio, costo)
            {

            }

            public override string ConsultarDatos()
            {
                return "Libro: " + NombreProducto + " colorPortada " + ColorPortada + ", Precio: " + PrecioVenta + ", costo " + CostoFabrica;
            }

            public override void ModificarDatos(string nombreProducto)
            {
                NombreProducto = nombreProducto;
           }

            public override string imprimirDatos()
            {
                return "DVD: " + NombreProducto + " Precio: " + PrecioVenta;
            }

        }

        class Program
        {
            static void Main(string[] args)
            {

                Libro miLibro = new Libro("Biblioteca del programador", "Blanco", 54.95, 39.95);
                DVD miDVD = new DVD("Curso multimedia", "Gris", 29.95, 19.95);
                Console.WriteLine("Imprimir productos.");
                Console.WriteLine(miLibro.imprimirDatos());
                Console.WriteLine(miDVD.imprimirDatos());

                Console.WriteLine("============================");
                Console.WriteLine("Consultar productos.");
                Console.WriteLine(miLibro.ConsultarDatos());
                Console.WriteLine(miDVD.ConsultarDatos());

                Console.WriteLine("============================");
                Console.WriteLine("Libros Modificado");
                miLibro.ModificarDatos("Programacion CSharp");

                Console.WriteLine(miLibro.imprimirDatos());

                Console.WriteLine("============================");
                Console.WriteLine("DVD Modificado");
                miDVD.ModificarDatos("Curso de Cuidados de Gatos ");
                Console.WriteLine(miDVD.imprimirDatos());

                Console.WriteLine("presione enter para terminar.");
                Console.ReadLine();

            }
        }
    }

}