using System;
using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class AppointmentService
    {
        /*
            No cumple el principio SRP, porque esta  clase destinada a solo crear una cita tambien tiene la
            responsabilidad de verificar si los datos son correctos, y no tiene expertos en infomacion.
        */

        public static List<Cita> listaCitas = new List<Cita>();
        public static string CreateAppointment(Persona persona, Doctor doctor, DateTime dia, string lugar, string id)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Cita cita1 = new Cita (persona, doctor, dia, lugar, id);
            stringBuilder = Verificador.Verificar(stringBuilder, cita1, listaCitas);
            
            return stringBuilder.ToString();
        }
    }
}
