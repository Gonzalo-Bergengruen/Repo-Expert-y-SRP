using System;

namespace Library
{
    public class Persona
    {
        public string Name{get;}
        public string ID{get;}
        public string PhoneNumber{get;}
        public string Edad{get;}

        public Persona(string name, string id, string phoneNumber, DateTime fechaN)
        {
            this.Name = name;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.Edad = (DateTime.Today.AddTicks(-fechaN.Ticks).Year - 1).ToString();
        }
    }
}