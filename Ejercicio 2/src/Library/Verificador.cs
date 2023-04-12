using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class Verificador
    {
        public static StringBuilder Verificar(StringBuilder stringBuilder, Cita cita, List<Cita> listaCitas)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(cita.Persona.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.Persona.ID))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.Persona.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.Persona.Edad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required.\n");
                valid = false;
            }


            if (string.IsNullOrEmpty(cita.Doctor.Nombre))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.Doctor.Especialidad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor specialty' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.Dia.ToString()))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment day and time' is required.\n");
                valid = false;
            }

            if (string.IsNullOrEmpty(cita.ID))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment id' is required.\n");
                valid = false;
            } else{
                foreach (Cita c in listaCitas)
                {
                    if (c.ID == cita.ID)
                    {
                        stringBuilder.Append("Unable to schedule appointment, 'appointment id' is already been use.\n");
                        valid = false;
                    }
                }
                listaCitas.Add(cita);
            }

            if (valid == false)
            {
                cita = null;
            } else {
                stringBuilder.Append("Appoinment scheduled.");
            }

            return stringBuilder;
        }
    }
}