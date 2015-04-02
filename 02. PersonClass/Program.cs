namespace _02.PersonClass
{
    using System;

    public class Person
    {
        private string name;

        public Person(string name, int? age = null)
        {
            this.Age = age;
            this.Name = name;
        }

        public int? Age { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name - {0}, age - {1}", this.Name, this.Age == null ? "not specified" : this.Age.ToString());
        }
    }
}
