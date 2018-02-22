using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DSAL1_KFS
{
    class BirthdayProblem
    {
        public BirthdayProblem(int N)
        {
            Console.WriteLine("expected value is {0}", expected(N));
        }

        public int BirthdayProblemInt(int N,Random rnd)
        {
            List<int> sequences = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int temp = rnd.Next(0, N);
                if (CompareDate(temp, sequences))
                {
                    return sequences.Count;
                }
                sequences.Add(temp);
            }
            Console.WriteLine("Something went wrong!");
            return 0;
        }

        bool CompareDate(int N, List<int> sequence)
        {
            return sequence.Contains(N);
        }

        public double expected(int N)
        {
            return Math.Sqrt(Math.PI * N / 2);
        }
    }
}
