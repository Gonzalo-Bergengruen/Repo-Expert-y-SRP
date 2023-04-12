using System.Collections;

namespace SRP
{
    public class Estanteria
    {
        public string Codigo{get;}
        public ArrayList listaLibros = new ArrayList();

        public Estanteria(string codigo)
        {
            this.Codigo = codigo;
        }
        
        public void AgregarLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        public void SacarLibro(Libro libro)
        {
            listaLibros.Remove(libro);
        }
    }
}