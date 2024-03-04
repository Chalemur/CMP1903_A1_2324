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
        private int _value;

        
        //Method
        public int Roll()
        {   
            Random random = new Random();
            _value = random.Next(1, 7);   //Generate a random number between 1 and 6
            Console.WriteLine($"The value of the roll is: {_value}");  //Print result to user
            return _value;
        }
    }
}
