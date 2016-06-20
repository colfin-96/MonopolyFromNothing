using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of players:");
            int n = Console.Read();

            Dice oDice = new Dice();
            Player[] oPlayers = new Player[n];
            Board oBoard = new Board();

            for (int i = 0; i < n; i++) 
            {
                oPlayers[i].SetUpPlayer();
            }



            bool isGameOver = false;
            int playersturn = 0;

            while(isGameOver == false)
            {

                oPlayers[playersturn].PlayTurn(oBoard,oDice);


                playersturn = (playersturn + 1) % n;

                for (int i = 0; i < n; i++)
                {
                    if (oPlayers[i].isBankrupt() == true)
                    {
                        isGameOver = true; //If One person Bankrupt then Game is Over.
                    }
                }
            }

            

            



        }
    }
}
