using System;
using System.Collections.Generic;
using System.Text;

namespace snake_and_ladder_game
{
    class UC_2DiceRoll
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int diceRoll = random.Next(0, 7);
            Console.WriteLine("You got " + diceRoll + " in dice roll.");
        }
    }
}
    

