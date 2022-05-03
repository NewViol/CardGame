using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._11._21_21card
{
    class CardBox
    {
        public static Random _rnd = new Random();
        private int _count;
        private int[] _cards;
        private int _counter = 0;

        public CardBox(int count)
        {
            _count = count;
            _cards = new int[_count];
            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i] = i;
            }
            Shuffle();
        }

        public void Shuffle()
        {
            for (int i = 0; i < _cards.Length; i++)
            {
                int rnd = _rnd.Next(_cards.Length);
                int tmp = _cards[i];
                _cards[i] = _cards[rnd];
                _cards[rnd] = tmp;
            }
        }

        public Card GetNextCard()
        {
            if (_counter == _cards.Length)
            {
                _counter = 0;
                Shuffle();
            }
            return new Card(_cards[_counter++]);
        }
    }
}
