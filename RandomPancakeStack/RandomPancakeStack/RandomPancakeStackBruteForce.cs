using System.Collections.Generic;
using System.Linq;


namespace RandomPancakeStackBruteForce
{
    public class RandomPancakeStackDiv2
    {
        public double expectedDeliciousness(int[] d)
        {
            double ed = 0;

            int n = d.Length;

            for (int i = 1; i < 1 << n; i++)
            {
                List<int> used = new List<int>();
                List<int> unused = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    if ((i & 1 << j) != 0)
                    {
                        used.Add(j);
                    }
                    else
                    {
                        unused.Add(j);
                    }
                }

                if (unused.Count == 0)
                {
                    ed += s(i, n, d) * p(n, n);
                }
                else if (unused.Max() > used.Min())
                {
                    ed += s(i, n, d)* p(used.Count + 1, n) * unused.Count(x => x > used.Min());
                }
            }

            return ed;
        }

        private double p(int k, int n)
        {
            double pr = 1;
            for (int i = 0; i < k; i++)
            {
                pr *= 1/(double)(n - i);
            }
            return pr;
        }

        private double s(int i, int n, int[] d)
        {
            double s = 0;

            for (int j = 0; j < n; j++)
            {
                if ((i & 1 << j) != 0)
                {
                    s += d[j];
                }
            }

            return s;
        }
    }
}