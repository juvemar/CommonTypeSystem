namespace _01.StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        //fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private string course;

        //constructors
        public Student(string firstName, string middleName, string lastName, string ssn,
            string address, string mobilePhone, string email, string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SSN cannot be null or empty");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Addres cannot be null or empty");
                }
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Mobile phone cannot be null or empty");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be null or empty");
                }
                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course cannot be null or empty");
                }
                this.course = value;
            }
        }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        //methods
        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.MobilePhone.Equals((obj as Student).MobilePhone)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Faculty.Equals((obj as Student).Faculty)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.University.Equals((obj as Student).University)) return false;
            if (!this.Specialty.Equals((obj as Student).Specialty)) return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 23 * this.SSN.GetHashCode();
            hash *= 17 * this.Course.GetHashCode();
            return hash;
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(first.Equals(second));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} {2}:\n", this.FirstName, this.MiddleName, this.LastName);
            result.AppendFormat("SSN - {0}\nAddress - {1}\nMobile phone - {2}\n", this.SSN, this.Address, this.MobilePhone);
            result.AppendFormat("Email - {0}\nCourse - {1}\n", this.Email, this.Course);
            result.AppendFormat("Specialty - {0}\nUniversity - {1}\nFaculty - {2}", this.Specialty, this.University, this.Faculty);

            return result.ToString();
        }

        public object Clone()
        {
            return new Student(this.firstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email,
                this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            var thisFullName = this.FirstName + this.MiddleName + this.LastName;
            var otherFullName = this.FirstName + this.MiddleName + this.LastName;
            if (thisFullName.Equals(otherFullName))
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return thisFullName.CompareTo(otherFullName);
        }
    }
}
