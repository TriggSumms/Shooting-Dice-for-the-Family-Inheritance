using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer: Player
    {
        public override void Play(Player other)

        {
            Console.WriteLine("Big and Careful Roller coming through...");
            int bigRollandCarefulRoll = new Random().Next(3, (DiceSize + 1));
            int myRoll = bigRollandCarefulRoll;
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                //Not sure what ta put in this (myRoll < otherRoll) or Roll(), still working on solving these issues 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }

            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}
