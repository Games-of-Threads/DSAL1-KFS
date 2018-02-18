using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL1_KFS
{
    class CouponCollectorProblem
    {
        public CouponCollectorProblem(int N)
        {
            //variable for counting amount of attempts
            int attempts = 0;
            //generating the array to contain all values, they should presently be null
            int[] sequences = new int[N];
            //begining loop
            for (int i = 0; i < N; i++)
            {
                //adding +1 per attempt in the beginning of the attempt
                attempts++;
                //making new random value.
                int temp = new Random().Next(0, N);
                //checks if the value exist in the array and if it isn't it ensures the for loop doesn't prematuraly stops.
                if (!CompareDate(temp, sequences))
                {
                    sequences[i] = temp;
                }
                else
                {
                    i--;
                }
                //Console.WriteLine("attempts:{0}\ncurrentsize:{1}", attempts, i);
            }
            Console.WriteLine("it took {0} attempts to write all values",attempts);
        }

        //note this is a copy of the main function with the difference for multiple uses.
        public int CouponCollectorProblemInt(int N)
        {
            int attempts = 0;
            int[] sequences = new int[N];
            for (int i = 0; i < N; i++)
            {
                attempts++;
                int temp = new Random().Next(0, N);
                if (!CompareDate(temp, sequences))
                {
                    sequences[i] = temp;
                }
                else
                {
                    i--;
                }
                //Console.WriteLine("attempts:{0}\ncurrentsize:{1}",attempts,i);
            }
            return attempts;
        }

        //this compared the current number N with all numbers in the current array, if a double has been found it returns true, otherwise false.
        bool CompareDate(int N, int[] sequence)
        {
            for (int i = 0; i < sequence.Length-1; i++)
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
