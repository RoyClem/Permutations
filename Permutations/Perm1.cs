using System;

namespace Permutations
{
    public class Perm1 : PermBase
    {
        private int _totalPerms;
        // default constructor
        public Perm1()  {  }
        
        public Perm1(string values)  
        { 
            this.values = values;
        }

        public override void Display()
        {
            base.Display();
            // start with initial depth 0
            DoWork(values.ToCharArray(), 0, values.Length - 1);
            Console.WriteLine("Total Permutations: " + _totalPerms++);
        }

        private void DoWork(char[] list, int depth, int max)
        {
            // recursively swap the array values

            if (depth == max) { 
                // show the permutation
                Console.WriteLine(list);
                _totalPerms++;
            }
            else
            for (int i = depth; i <= max; i++)
            {
                Swap(ref list[depth], ref list[i]);
                DoWork(list, depth + 1, max);
                // backtrack
                Swap(ref list[depth], ref list[i]);
            }
        }

        private void Swap(ref char a, ref char b)
        {
            if (a == b) return;     // don't swap if values are same

            // perform a bitwise swap - the XOR of two values
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}