using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libro book1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro book2 = new Libro("Pro C#","Troelsen","001-035");
            Estanteria estanteria1 = new Estanteria("#0001");
            Estanteria estanteria2 = new Estanteria("#0002");
            Sector sector1 = new Sector("A");
            estanteria1.AgregarLibro(book1);
            estanteria1.AgregarLibro(book2);
            sector1.AñadirEstanteria(estanteria1);
            sector1.AñadirEstanteria(estanteria2);
        }
    }
}