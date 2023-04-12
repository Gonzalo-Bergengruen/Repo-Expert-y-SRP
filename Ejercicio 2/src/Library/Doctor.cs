namespace Library
{
    public class Doctor
    {
        public string Nombre{get;}
        public string Especialidad {get;}

        public Doctor(string nombre, string especialidad)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }
    }
}