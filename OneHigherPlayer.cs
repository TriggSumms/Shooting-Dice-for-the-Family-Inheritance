using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)

        {
           
            int OtherRoll = other.Roll();

            int HigherRoll = OtherRoll + 1;

            Console.WriteLine($"{Name} rolls a {HigherRoll}");
            Console.WriteLine($"{other.Name} rolls a {OtherRoll}");
            

            if (HigherRoll > OtherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (HigherRoll < OtherRoll)
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