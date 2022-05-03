using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._11._21_21card
{
    class Game
    {
        static public void Start()
        {
            CardBox cardBox = new CardBox(36);

            List<Card> banker = new List<Card> { };
            List<Card> player = new List<Card> { };
            int player_value = 0;
            int banker_value = 0;

            int choise = 0;
            player.Add(cardBox.GetNextCard());
            player_value += player[player.Count - 1].GetValue();
            banker.Add(cardBox.GetNextCard());
            banker_value += banker[banker.Count - 1].GetValue();

            Console.WriteLine("Your cards:");
            for (int i = 0; i < player.Count; i++)
            {
                Console.WriteLine("  " + player[i]);
            }

            while (choise == 0 && player_value < 21 && banker_value < 21)
            {
                Console.WriteLine("[0] Get Card");
                Console.WriteLine("[another] End");
                choise = Convert.ToInt32(Console.ReadLine());

                if (choise == 0)
                {
                    player.Add(cardBox.GetNextCard());
                    player_value += player[player.Count - 1].GetValue();
                    banker.Add(cardBox.GetNextCard());
                    banker_value += banker[banker.Count - 1].GetValue();

                    Console.WriteLine("Your cards:");
                    for (int i = 0; i < player.Count; i++)
                    {
                        Console.WriteLine("  " + player[i]);
                    }
                }
            }

            if (player_value > 21)
            {
                Console.WriteLine("You lose");
            }
            else if (banker_value > 21)
            {
                Console.WriteLine("You win");
            }
            else if (player_value == 21)
            {
                Console.WriteLine("You win");
            }
            else if (banker_value == 21)
            {
                Console.WriteLine("You lose");
            }
            else if (player_value < banker_value)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win");
            }

            Console.ReadKey();
        }
    }
}
