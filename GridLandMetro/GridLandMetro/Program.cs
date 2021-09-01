using System;

namespace GridLandMetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] input = new int[,] { { 4, 4, 3 }, { 2, 2, 3 }, { 3, 1, 4 }, { 4, 4, 4 } };
            //int[,] input = new int[,] { { 4, 4, 4 }, { 1, 1, 4 }, { 2, 2, 4 }, { 3, 1, 2 }, { 4, 2, 3 } };

            int i, j, row, c1, c2;
            int n = input[0, 0];
            int m = input[0, 1];
            int k = input[0, 2];
            int[,] grid = new int[n, m];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    grid[i, j] = 1;
                }
            }

            for (i = 1; i <= k; i++)
            {
                row = input[i, 0] - 1;
                c1 = input[i, 1] - 1;
                c2 = input[i, 2] - 1;
                for (j = c1; j <= c2; j++)
                {
                    grid[row, j] = 0;
                }
            }

            int LampPostCount = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    LampPostCount = LampPostCount + grid[i, j];
                }
            }

            Console.WriteLine(LampPostCount);
        }

    }
}
