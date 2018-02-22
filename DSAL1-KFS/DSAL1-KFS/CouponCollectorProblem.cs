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
            Console.WriteLine("expected value is {0}", expected(N));
        }

        public int CouponCollectorProblemInt(int N,Random rnd)
        {
            List<int> sequence = new List<int>();

            int attempts = 0;
            int remaining = N;

            while (true)
            {
                attempts++;
                int temp = rnd.Next(0, N);
                if (!CompareDate(temp,sequence))
                {
                    sequence.Add(temp);
                    remaining--;
                }

                if (remaining <= 0)
                {
                    break;
                }
            }
            return attempts;
        }

        bool CompareDate(int N, List<int> sequence)
        {
            return sequence.Contains(N);
        }

        public double expected(int N)
        {
            float h = 0.0f;
            for (int i = 1; i <= N; i++)
            {
                h += 1 / (float)i;
            }

            return N * h;
        }
    }
}
