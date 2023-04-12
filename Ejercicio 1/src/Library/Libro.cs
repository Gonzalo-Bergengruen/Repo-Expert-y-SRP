using System;

namespace SRP
{
    public class Libro
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Libro(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        /*
            No se cumplía el principio SRP porque tenia la responsabilidad de saber la informacion del libro y de su
            ubicación haciendo que tenga dos responsabilidades envés de solo una, lo que incumple el principio SRP.
        */
    }
}