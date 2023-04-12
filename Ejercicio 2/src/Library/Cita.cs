using System;

namespace Library
{
    public class Cita
    {
        public Persona Persona {get;}
        public Doctor Doctor {get;}
        public DateTime Dia {get;}
        public string Lugar {get;}
        public string ID {get;}
        public Cita(Persona persona, Doctor doctor, DateTime dia, string lugar,string id)
        {
            this.Persona = persona;
            this.Doctor = doctor;
            this.Dia = dia;
            this.Lugar = lugar;
            this.ID = id;
        }
    }
}