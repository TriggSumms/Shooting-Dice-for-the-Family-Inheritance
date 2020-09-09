using System;
using System.Collections.Generic;

namespace ShootingDice
{
    //Need to test this one
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> TauntList = new List<string>()
        {
            "Rollin all em flat bois n' front of all your friends...",
            "You look like a lil caveman rollin the wheel for the first time, get ya game together DangusMane",
            "Wow....insert: 'Quote from Gordon Ramsey'"
        };

        public override void Play(Player other)

        {
            //Still havent figured out this one


            //int secretNumber = 68;
            int randomTaunt = new Random().Next(0, TauntList.Count);
            
            //Need to pull specific numeric in the index
            int myRoll = Roll(); 
            
            int otherRoll = other.Roll();
            
           

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine(TauntList[randomTaunt]);
            
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            
            if (myRoll > otherRoll)
            {
               Console.WriteLine(randomTaunt);
                Console.WriteLine($"{Name} Wins!");
                //Console.WriteLine(TauntList[randomTaunt]);
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                
                //Console.WriteLine(randomTaunt);
                Console.WriteLine("It's a tie");
                //Console.WriteLine(TauntList[randomTaunt]);
                
            }
        }
    }
}

