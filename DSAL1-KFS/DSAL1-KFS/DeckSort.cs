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
        int[] deck = new int[56];

        public DeckSort(Random rnd)
        {
            Console.WriteLine("DeckSort started");
            MakeDeck();
            ShuffleCards(rnd);
            ReadCards();
            Console.WriteLine("breakpoint");
            SortDeck();
            ReadCards();
            Console.ReadKey();
        }

        void MakeDeck()
        {
            for (int i = 0; i < 56; i++)
            {
                deck[i] = i + 1;
            }
        }

        public void ShuffleCards(Random rnd)
        {
            deck = deck.OrderBy(x => rnd.Next()).ToArray();
        }

        public void SortDeck()
        {
            for (int i = 0; i < 56; i++)
            {
                var lowest = i;
                for (int j = i+1; j < 56; j++)
                {
                    if (deck[j] < deck[lowest])
                    {
                        lowest = j;
                    }
                }
                var temp = deck[i];
                deck[i] = deck[lowest];
                deck[lowest] = temp;
            }
        }

        public void ReadCards()
        {
            for (int i = 0; i < 56; i++)
            {
                Console.WriteLine("value is {0}",deck[i]);
            }
        }
    }
}
