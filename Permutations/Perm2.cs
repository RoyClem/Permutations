using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    public class Perm2 : PermBase
    {
        public Perm2() { }

        public Perm2(string values)
        {
            this.values = values;
        }
        public override void Display()
        {
            base.Display();

            var perms = DoWork(values);

            foreach (var perm in perms)
                Console.WriteLine(perm);

            Console.WriteLine("Total Permutations: " + perms.Count());

        }
        private IEnumerable<string> DoWork(string value)
        {
            if (value.Length == 1) 
                return new List<string> { value };

            var perm = from c in value
                               from p in DoWork(new string(value.Where(x => x != c).ToArray()))
                               select c + p;

            return perm;
        }
    }
}
