using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._11._21_21card
{
    enum CardWeight { TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUIN, KING, ACE };
    enum CardSuit { Spades, Clubs, Hearts, Diamonds };

    class Card
    {
        public static string[] Weight { get; } = { "TWO", "THREE", "FOUR", "FIVE", "SIX",
                        "SEVEN", "EIGHT", "NINE", "TEN", "JACK", "QUIN", "KING", "ACE" };
        public static string[] Suits { get; } = { "Spades", "Clubs", "Hearts", "Diamonds" };

        private int _value;
        public Card(int value)
        {
            _value = value;
        }

        public CardWeight CardWeight { get => (CardWeight)(_value % 13); }

        public int GetValue()
        {
            int value = _value % 13;
            if (value == 12)
            {
                return 1;
            }
            else if (value == 11)
            {
                return 4;
            }
            else if (value == 10)
            {
                return 3;
            }
            else if (value == 9)
            {
                return 2;
            }
            return value + 2;
        }

        public CardSuit CardSuit { get => (CardSuit)(_value / 13); }

        public override string ToString()
        {
            return $"{Suits[_value / 13]} {Weight[_value % 13]}";
        }

    }
}
