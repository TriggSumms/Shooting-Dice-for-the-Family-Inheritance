using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll

    public class HumanPlayer : Player
    {
        public override void Play(Player other)

        {
            Console.WriteLine("Choose your roll while they aint lookin..ONLY~1-6~ONLY");
            string recordedRoll = Console.ReadLine();
            int myRoll = Int32.Parse(recordedRoll);
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}