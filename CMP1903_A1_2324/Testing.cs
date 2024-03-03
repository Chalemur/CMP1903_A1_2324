using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Properties
        private Game game = new();


        //Methods
        public void Main()
        {
           int sum = game.Sum();
           int die1 = game.die1.value;
           int die2 = game.die2.value;
           int die3 = game.die3.value;
           Debug.Assert(die1 >= 1 && die1 <= 6 && die2 >= 1 && die2 <= 6 && die3 >= 1 && die3 <= 6, "Value for dice is not valid");
           Debug.Assert(sum >= 3 && sum <= 18, "Sum not valid");

        }
    }
}
