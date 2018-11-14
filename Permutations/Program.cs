using System;

namespace Permutations
{
    class Program
    {
        static void Main()
        {
            Perm1 perm1 = new Perm1("ABC");
            perm1.Display();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Permutations Using Linq");
            Perm2 perm2 = new Perm2("ABC");
            perm2.Display();

            Console.ReadLine();
        }

    }
}
