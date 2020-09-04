using System;

namespace Library
{
    public class Doctor
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
        private string field;
        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                if (value != "" && value != null)
                    this.field = value;
            }
        }

        public Doctor(string name, string field)
        {
            this.Name = name;
            this.Field = field;
        }
    }
}