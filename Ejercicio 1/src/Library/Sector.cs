using System.Collections;

namespace SRP
{
    public class Sector
    {
        public string Codigo {get;}
        public ArrayList listaEstanterias = new ArrayList();

        public Sector (string codigo)
        {
            this.Codigo = codigo;
        }
        public void AñadirEstanteria(Estanteria estanteria)
        {
            listaEstanterias.Add(estanteria);
        }

        public void EliminarEstanteria(Estanteria estanteria)
        {
            listaEstanterias.Remove(estanteria);
        }
    }
}