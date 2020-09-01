using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        //Las validaciones de los valores podrían estar hechas en los setters y haría que el código esté más prolijo.
        //El código parece cumplir con el patrón Expert, sin embargo el SRP,en mi opinion, no se cumple debido a que una clase que crea
        //Appointments no debería conocer los datos personales de la persona que asistirá al mismo, solo debería saber que persona es la que irá,en cambio
        //la fecha, el lugar y el doctor asignado si son su responsabilidad.
        //En una posible solución podría crearse una clase distinta llamada "Person", la cual contenga
        //los datos personales de la persona que asistirá a la consulta, otra clase llamada "Appointment" la cual contenga estos datos, y una última clase (Como esta)
        //la cual crea los Appointments.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
