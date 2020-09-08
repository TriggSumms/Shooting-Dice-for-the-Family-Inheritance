using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string tauntz { get; set; }

        public override void Play(Player other)

        {
           //int luck = new Random().Next(-10, 11);
            int myRoll = Roll(); 
            
            int otherRoll = other.Roll();
            
           

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"The player snapped their neck towards their opponent and stated '{tauntz}'");
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