namespace RandomPancakeStack
{
    public class RandomPancakeStackDiv2
    {
        public double expectedDeliciousness(int[] d)
        {
            int n = d.Length;

            double ed = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    ed += d[i]*C(n - i - 1, j - 1)*factorial(n - j)/factorial(n);
                }
            }

            return ed;
        }

        private double C(int n, int k)
        {
            return (factorial(n)
                /(factorial(k)*factorial(n - k)));
        }

        private double factorial(int n)
        {
            if (n == 0) return 1;
            return n*factorial(n - 1);
        }
    }
}