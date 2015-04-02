namespace _02.PersonClass
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Person firstHuman = new Person("Pencho");
            Person secondHuman = new Person("Stancho", 25);

            Console.WriteLine(firstHuman);
            Console.WriteLine(secondHuman);
        }
    }
}
