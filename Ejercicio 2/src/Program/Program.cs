using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona1 = new Persona("Steven Jhonson", "986782342", "5555-555-555", new DateTime(2002, 8, 17, 0, 0, 0));
            Persona persona2 = new Persona("Ralf Manson", "", "5555-555-555", new DateTime(2002, 8, 17, 0, 0, 0));
            Doctor doctor = new Doctor("Armand", "Algo");
            string appointmentResult = AppointmentService.CreateAppointment(persona1, doctor, DateTime.Now, "Wall Street", "001");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(persona2, doctor, DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
