using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL1_KFS
{
    class Program
    {
        static void Main(string[] args)
        {
            MainBirthdayProblem();
            MainCouponCollectorProblem();
            Console.ReadKey();
        }

        static void MainBirthdayProblem()
        {
            Console.WriteLine("Please input the N value for the birthday Problem 1.4.44\nPlease don't write anything else as it'll break.");
            int N = int.Parse(Console.ReadLine());
            var BP = new BirthdayProblem(N);
            int[] sequence = new int[N];
            for (int i = 0; i < N; i++)
            {
                sequence[i] = BP.BirthdayProblemInt(N);
            }
            Console.WriteLine("the average was {0} with the N value being {1}", sequence.Average(), N);
            Console.ReadKey();
        }

        static void MainCouponCollectorProblem()
        {
            Console.WriteLine("Please input the N value for the birthday Problem 1.4.45\nPlease don't write anything else as it'll break.");
            int N = int.Parse(Console.ReadLine());
            var CCP = new CouponCollectorProblem(N);
            int[] sequence = new int[N];
            for (int i = 0; i < N; i++)
            {
                sequence[i] = CCP.CouponCollectorProblemInt(N);
            }
            Console.WriteLine("the average was {0} with the N value being {1}", sequence.Average(), N);
            Console.ReadKey();
        }
    }
}
