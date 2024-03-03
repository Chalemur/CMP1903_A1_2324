using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Properties
        public Die die1 = new();
        public Die die2 = new();
        public Die die3 = new();


        //Methods
        public int Sum()
        {
            int sum = die1.Roll() + die2.Roll() + die3.Roll();
            Console.WriteLine(sum);
            return sum;
        }

    }
}
