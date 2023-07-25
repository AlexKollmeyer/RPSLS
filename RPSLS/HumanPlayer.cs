using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {

        public HumanPlayer(string name): base(name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Type the associated number to select a gesture" +
                "1:rock" +
                "2:paper" +
                "3:scissors" +
                "4:lizard" +
                "5:spock");
            this.chosenGesture = gestures[Int32.Parse(Console.ReadLine())-1];
            Console.WriteLine($"{this.name} chooses {chosenGesture}");

        }
    }
}

