using System;

namespace Library
{
    public class Appointment
    {
        private string place;
        public string Place
        {
            get
            {
                return this.place;
            }
            set
            {
                if (value != "" && value != null)
                    this.place = value;
            }
        }
        private Datetime date;
        public DateTime Date{get; set;}
        private Person person;
        public Person Person{get; set;}
        private Doctor doctor;
        public Doctor Doctor{get; set;}
        
        public Appointment(string place, DateTime date, Person person, Doctor doctor)
        {
            this.Place = place;
            this.Date = date;
            this.Person = person;
            this.Doctor = doctor;
        }
    }
}