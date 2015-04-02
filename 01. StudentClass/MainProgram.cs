namespace _01.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class MainProgram
    {
        static void Main()
        {
            Student student = new Student("Pesho", "Peshkov", "Peshev", "8484848484", "Sofia, Mladost 1, blok 1023",
                "HTC", "pesh@gbd.bg", "Third", Specialty.Informatics, University.TU, Faculty.EI);
            Console.WriteLine(student.ToString());
        }
    }
}
