using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL1_KFS
{
    class BirthdayProblem
    {
        //given size the entire class is instantiated as a function with the N value for the assignment.
        public BirthdayProblem(int N)
        {
            //generating the array to contain all values, they should presently be null
            int[] sequences = new int[N];
            //begining loop
            for (int i = 0; i < N; i++)
            {
                //adding a random value between 0 and N-1 with no particular Random Seed
                sequences[i] = new Random().Next(0, N-1);
                //see CompareDate note
                if (CompareDate(sequences[i], sequences))
                {
                    //if succesfull it writes out what it found and breaks the Loop.
                    Console.WriteLine("Found the double and it's value was : {0}",sequences[i]);
                    break;
                }
            }
        }

        //note this is a copy of the main function with the difference for multiple uses.
        public int BirthdayProblemInt(int N)
        {
            int[] sequences = new int[N];
            for (int i = 0; i < N; i++)
            {
                sequences[i] = new Random().Next(0, N-1);
                if (CompareDate(sequences[i], sequences))
                {
                    return sequences[i];
                }
            }
            Console.WriteLine("Something went wrong!");
            return 0;
        }

        //this compared the current number N with all numbers in the current array, if a double has been found it returns true, otherwise false.
        bool CompareDate(int N, int[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (N == sequence[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
