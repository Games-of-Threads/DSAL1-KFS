using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace DSAL1_KFS
{
    class DeckSort
    {
        int[,] deck = new int[4,13];

        public enum Suit
        {
            Spades, Hearts, Clubs, Diamonds
        };

        public enum Side
        {
            ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
        };

        public DeckSort()
        {
            Console.WriteLine("DeckSort started");
            frustation();
            //ShuffleCards();
            ReadCards();
            Console.ReadKey();
        }

        public void ShuffleCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i, j] = (int) Suit.Spades;
                }
            }
            Random rnd = new Random();
            //deck = deck.OrderBy(x => rnd.Next()).ToArray();
            //for (int i = 0; i < 56; i++)
            //{
            //    cards = cards.OrderBy(x => new Random().Next()).ToArray();
            //}
            //cards.OrderBy(x => new Random().Next()).ToArray();
        }

        public void ReadCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.WriteLine("value is {0}", deck[i,j]);
                }
            }
        }

        void frustation()
        {
            deck[0, 0] = (int)Suit.Spades;
            deck[0, 0] = (int)Side.ace;
            deck[0, 1] = (int)Suit.Spades;
            deck[0, 1] = (int)Side.two;
            deck[0, 2] = (int)Suit.Spades;
            deck[0, 2] = (int)Side.three;
            deck[0, 3] = (int)Suit.Spades;
            deck[0, 3] = (int)Side.four;
            deck[0, 4] = (int)Suit.Spades;
            deck[0, 4] = (int)Side.five;
            deck[0, 5] = (int)Suit.Spades;
            deck[0, 5] = (int)Side.six;
            deck[0, 6] = (int)Suit.Spades;
            deck[0, 6] = (int)Side.seven;
            deck[0, 7] = (int)Suit.Spades;
            deck[0, 7] = (int)Side.eight;
            deck[0, 8] = (int)Suit.Spades;
            deck[0, 8] = (int)Side.nine;
            deck[0, 9] = (int)Suit.Spades;
            deck[0, 9] = (int)Side.ten;
            deck[0, 10] = (int)Suit.Spades;
            deck[0, 10] = (int)Side.jack;
            deck[0, 11] = (int)Suit.Spades;
            deck[0, 11] = (int)Side.queen;
            deck[0, 12] = (int)Suit.Spades;
            deck[0, 12] = (int)Side.king;

            deck[1, 0] = (int)Suit.Hearts;
            deck[1, 0] = (int)Side.ace;
            deck[1, 1] = (int)Suit.Hearts;
            deck[1, 1] = (int)Side.two;
            deck[1, 2] = (int)Suit.Hearts;
            deck[1, 2] = (int)Side.three;
            deck[1, 3] = (int)Suit.Hearts;
            deck[1, 3] = (int)Side.four;
            deck[1, 4] = (int)Suit.Hearts;
            deck[1, 4] = (int)Side.five;
            deck[1, 5] = (int)Suit.Hearts;
            deck[1, 5] = (int)Side.six;
            deck[1, 6] = (int)Suit.Hearts;
            deck[1, 6] = (int)Side.seven;
            deck[1, 7] = (int)Suit.Hearts;
            deck[1, 7] = (int)Side.eight;
            deck[1, 8] = (int)Suit.Hearts;
            deck[1, 8] = (int)Side.nine;
            deck[1, 9] = (int)Suit.Hearts;
            deck[1, 9] = (int)Side.ten;
            deck[1, 10] = (int)Suit.Hearts;
            deck[1, 10] = (int)Side.jack;
            deck[1, 11] = (int)Suit.Hearts;
            deck[1, 11] = (int)Side.queen;
            deck[1, 12] = (int)Suit.Hearts;
            deck[1, 12] = (int)Side.king;

            deck[2, 0] = (int)Suit.Clubs;
            deck[2, 0] = (int)Side.ace;
            deck[2, 1] = (int)Suit.Clubs;
            deck[2, 1] = (int)Side.two;
            deck[2, 2] = (int)Suit.Clubs;
            deck[2, 2] = (int)Side.three;
            deck[2, 3] = (int)Suit.Clubs;
            deck[2, 3] = (int)Side.four;
            deck[2, 4] = (int)Suit.Clubs;
            deck[2, 4] = (int)Side.five;
            deck[2, 5] = (int)Suit.Clubs;
            deck[2, 5] = (int)Side.six;
            deck[2, 6] = (int)Suit.Clubs;
            deck[2, 6] = (int)Side.seven;
            deck[2, 7] = (int)Suit.Clubs;
            deck[2, 7] = (int)Side.eight;
            deck[2, 8] = (int)Suit.Clubs;
            deck[2, 8] = (int)Side.nine;
            deck[2, 9] = (int)Suit.Clubs;
            deck[2, 9] = (int)Side.ten;
            deck[2, 10] = (int)Suit.Clubs;
            deck[2, 10] = (int)Side.jack;
            deck[2, 11] = (int)Suit.Clubs;
            deck[2, 11] = (int)Side.queen;
            deck[2, 12] = (int)Suit.Clubs;
            deck[2, 12] = (int)Side.king;

            deck[3, 0] = (int)Suit.Diamonds;
            deck[3, 0] = (int)Side.ace;
            deck[3, 1] = (int)Suit.Diamonds;
            deck[3, 1] = (int)Side.two;
            deck[3, 2] = (int)Suit.Diamonds;
            deck[3, 2] = (int)Side.three;
            deck[3, 3] = (int)Suit.Diamonds;
            deck[3, 3] = (int)Side.four;
            deck[3, 4] = (int)Suit.Diamonds;
            deck[3, 4] = (int)Side.five;
            deck[3, 5] = (int)Suit.Diamonds;
            deck[3, 5] = (int)Side.six;
            deck[3, 6] = (int)Suit.Diamonds;
            deck[3, 6] = (int)Side.seven;
            deck[3, 7] = (int)Suit.Diamonds;
            deck[3, 7] = (int)Side.eight;
            deck[3, 8] = (int)Suit.Diamonds;
            deck[3, 8] = (int)Side.nine;
            deck[3, 9] = (int)Suit.Diamonds;
            deck[3, 9] = (int)Side.ten;
            deck[3, 10] = (int)Suit.Diamonds;
            deck[3, 10] = (int)Side.jack;
            deck[3, 11] = (int)Suit.Diamonds;
            deck[3, 11] = (int)Side.queen;
            deck[3, 12] = (int)Suit.Diamonds;
            deck[3, 12] = (int)Side.king;
        }
    }
}
