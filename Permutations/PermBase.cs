using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public abstract class PermBase
    {
        public string values { get; set;}

        public virtual void Display() 
        {
            Console.WriteLine("Initial values: " + values);
        }
    }
}
