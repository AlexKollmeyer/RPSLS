using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {

        public ComputerPlayer(string name) : base(name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        public override void ChooseGesture()
        {
            Random rnd = new Random();
            int num = rnd.Next(0,gestures.Count());
            this.chosenGesture=gestures[num];
            Console.WriteLine($"The computer chooses {chosenGesture}");
        }
    }
}
