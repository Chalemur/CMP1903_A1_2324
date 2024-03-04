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
        private Game _game = new Game();  // Creates game object
        
        
        //Methods
        public void Main()
        {
           int sum = _game.Sum();  //Runs game method and gets a value for the sum of the three dice rolls
           int die1 = _game.die1Roll;
           int die2 = _game.die2Roll;
           int die3 = _game.die3Roll;  //assigns dice roll value from game object to a variable for comparison
           Debug.Assert(die1 >= 1 && die1 <= 6 && die2 >= 1 && die2 <= 6 && die3 >= 1 && die3 <= 6, "Value for dice is not valid");  //Checks if all dice rolls are between 1-6
           Debug.Assert(sum >= 3 && sum <= 18, "Sum not valid");  //Checks if sum is valid by making sure its within a certain range of accepted values
        
        }
    }
}
