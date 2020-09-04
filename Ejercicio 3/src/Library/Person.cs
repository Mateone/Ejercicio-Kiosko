using System;

namespace Library
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != "" && value != null)
                    this.name = value;
            }
        }
        private string id;
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value != "" && value != null)
                    this.id = value;
            }
        }

        private string phone;
        public string Phone
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value != "" && value != null)
                    this.phone = value;
            }
        }
        public Person(string name, string id, string phone)
        {
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
        }
    }
}