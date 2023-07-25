using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:" +
                "\r\n You and your oppenent will both select one of the gestures(rock, paper, scissors, lizard, and Spock.) and the winner is based off the list below. "+
                "\nRock crushes Scissors" +
                "\r\nScissors cuts Paper " +
                "\r\nPaper covers Rock" +
                "\r\nRock crushes Lizard" +
                "\r\nLizard poisons Spock" +
                "\r\nSpock smashes Scissors" +
                "\r\nScissors decapitates Lizard" +
                "\r\nLizard eats Paper" +
                "\r\nPaper disproves Spock" +
                "\r\nSpock vaporizes Rock");
        }

        public int ChooseNumberOfHumanPlayers()
        {

            Console.WriteLine("Choose One or two players");
            int numberOfHumanPlayers = Int32.Parse(Console.ReadLine());
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.WriteLine("Player one enter your name");
            playerOne = new HumanPlayer(Console.ReadLine());
            if (numberOfHumanPlayers == 1)
            {
                playerTwo = new ComputerPlayer("PlayerTwo");
            }
            else
            {
                Console.WriteLine("Player two enter your name");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
        }

        public void CompareGestures(HumanPlayer playerOne,Player playertwo)
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
