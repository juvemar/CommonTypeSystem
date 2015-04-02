namespace _05.BitArray
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            var firstArr = new BitArray64(2345L);

            Console.WriteLine("Initial value:");
            foreach (var bit in firstArr)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(firstArr.GetHashCode());

            firstArr[5] = 0;

            Console.WriteLine("\nAfter the 5th bit was changed to 0:");
            foreach (var bit in firstArr)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(firstArr.GetHashCode());
        }
    }
}