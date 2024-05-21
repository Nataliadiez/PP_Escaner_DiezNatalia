using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de parámetros para informes
            int cantidad;
            int extension;
            string resumen;

            //Instanciación de libros
            Libro libro1 = new Libro("Yerma", "García Lorca, Federico", 1995, "1114", "22222", 27);
            Libro libro2 = new Libro("Los hombres que no amaban a las mujeres", "Stieg Larsson", 2005, "1452", "33333", 600);
            Libro libro3 = new Libro("La chica que soñaba con una cerilla y un bidón de gasolina", "Stieg Larsson", 2006, "1156", "44444", 700);
            Libro libro4 = new Libro("La reina en el palacio de las corrientes de aire", "Stieg Larsson", 2007, "1254", "55555", 800);
            Libro libro5 = new Libro("La reina en XXXel palacio", "Stieg Larsson", 2007, "1254", "55555", 800);
            Libro libro6 = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, "2345", "66666", 417);
            Libro libro7 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605, "9876", "77777", 1072);
            Libro libro8 = new Libro("El amor en los tiempos del cólera", "Gabriel García Márquez", 1985, "3456", "88888", 348);
            Libro libro9 = new Libro("1984", "George Orwell", 1949, "4567", "99999", 328);
            Libro libro10 = new Libro("Fahrenheit 451", "Ray Bradbury", 1953, "5678", "11111", 194);

            //Instanciación de mapas
            Mapa mapa1 = new Mapa("Ciudad Autónoma de Buenos Aires", "Instituto de geografía", 2022, "numNorm", "8888", 30, 20);
            Mapa mapa2 = new Mapa("Provincia de Mendoza", "Instituto de geografía", 2010, "numNorm", "7757", 30, 20);
            Mapa mapa3 = new Mapa("Provincia de Córdoba", "Instituto de Cartografía", 2018, "numNorm1", "1234", 35, 25);
            Mapa mapa4 = new Mapa("Provincia de Santa Fe", "Geografía Nacional", 2015, "numNorm2", "5678", 40, 30);
            Mapa mapa5 = new Mapa("Provincia de Tucumán", "Cartografía Argentina", 2021, "numNorm3", "9101", 25, 15);

            //Instanciación de scanners
            Escaner escanerMapa = new Escaner("Hitachi", Escaner.TipoDoc.mapa);
            Escaner escanerLibro = new Escaner("Sony", Escaner.TipoDoc.libro);

            //Agregar un libro a un escaner de libro
            bool escanearDocumento = escanerLibro + libro1;
            escanearDocumento = escanerLibro + libro2;
            escanearDocumento = escanerLibro + libro3;
            escanearDocumento = escanerLibro + libro4;
            escanearDocumento = escanerLibro + libro5;
            escanearDocumento = escanerLibro + libro6;
            escanearDocumento = escanerLibro + libro7;
            escanearDocumento = escanerLibro + libro8;
            escanearDocumento = escanerLibro + libro9;
            escanearDocumento = escanerLibro + libro10;
            Console.WriteLine($"Agregar un libro a un escaner de Libros: {escanearDocumento}\n");

            //Agregar un mapa a un escaner de mapas
            escanearDocumento = escanerMapa + mapa1;
            escanearDocumento = escanerMapa + mapa2;
            escanearDocumento = escanerMapa + mapa3;
            escanearDocumento = escanerMapa + mapa4;
            escanearDocumento = escanerMapa + mapa5;
            Console.WriteLine($"Agregar un mapa a un escaner de Mapas: {escanearDocumento}\n");


            //Agregar un mapa a un escaner de libros
            escanearDocumento = escanerLibro + mapa1;
            Console.WriteLine($"Agregar un mapa a un escaner de Libros: {escanearDocumento}\n");

            //Agregar un libro a un escaner de mapas
            escanearDocumento = escanerMapa + libro1;
            Console.WriteLine($"Agregar un libro a un escaner de Mapas: {escanearDocumento}\n");

            //Cambiar el estado a los documentos
            Console.WriteLine($"Estado de {mapa1.Titulo}: {mapa1.Estado}");
            Console.WriteLine($"Cambiar estado de {mapa1.Titulo}: {escanerMapa.CambiarEstadoDocumento(mapa1)}");
            Console.WriteLine($"Estado de {mapa1.Titulo}: {mapa1.Estado}\n");

            //Libros diferentes
            Console.WriteLine($"¿Los libros son iguales? {libro4 == libro5}");
            Console.WriteLine($"¿Los libros son iguales? {libro4 == libro8}");

            //En escaner
            bool cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro8);
            //En revision
            cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro9);
            cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro9);
            //Terminados
            cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro10);
            cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro10);
            cambioDeEstado = escanerLibro.CambiarEstadoDocumento(libro10);

            //Informes de libros
            Console.WriteLine("INFORMES DE LIBROS\n");
            Console.WriteLine("DISTRIBUIDOS");
            Informes.MostrarDistribuidos(escanerLibro, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("EN ESCANER");
            Informes.MostrarEnEscaner(escanerLibro, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("EN REVISION");
            Informes.MostrarEnRevision(escanerLibro, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("TERMINADOS");
            Informes.MostrarTerminados(escanerLibro, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);

            //Informes de mapas
            Console.WriteLine("INFORMES DE MAPAS\n");
            Console.WriteLine("DISTRIBUIDOS");
            Informes.MostrarDistribuidos(escanerMapa, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("EN ESCANER");
            Informes.MostrarEnEscaner(escanerMapa, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("EN REVISION");
            Informes.MostrarEnRevision(escanerMapa, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);
            Console.WriteLine("TERMINADOS");
            Informes.MostrarTerminados(escanerMapa, out extension, out cantidad, out resumen);
            Console.WriteLine(resumen);

            Console.ReadKey();

        }
    }
}
