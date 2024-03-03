using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property
        public int value;


        //Method
        public int Roll()
        {
            Random random = new();
            value = random.Next(1, 7);
            Console.WriteLine(value);
            return value;
        }


    }
}
