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
        //public Die die1 = new();
        //public Die die2 = new();
        //public Die die3 = new();


        //Methods
        //public int Sum()
        //{
            //int sum = die1.Roll() + die2.Roll() + die3.Roll();
            //Console.WriteLine(sum);
            //return sum;
        //}


        //Properties
        private Die _die1 = new Die();
        private Die _die2 = new Die();
        private Die _die3 = new Die();  //Creates 3 die objects
        public int die1Roll = 0;
        public int die2Roll = 0;
        public int die3Roll = 0;  //Creates variables that dice roll values can be assigned to and stored

        
        //Methods
        public int Sum()
        {
            die1Roll = _die1.Roll();
            die2Roll = _die2.Roll();
            die3Roll = _die3.Roll();  //Rolls all 3 dice
            int sum = die1Roll + die2Roll + die3Roll;  //Adds sum of dice rolls
            Console.WriteLine(sum);  //Prints sum to user
            return sum;
        }
    }
}
