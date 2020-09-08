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

        //Not working
        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize, need to declare new variable and then tie in with selector
            return new Random().Next(DiceSize) + 1;

        }

    }
}