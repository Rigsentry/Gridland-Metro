using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gridland_Metro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 4;
            int k = 3;
            int lampostCount = 0;
            int railroadCount = 0; 
            int[,] array2D = new int[,] { { 2, 2, 3 }, { 3, 1, 4 }, { 4, 4, 4 }};
            for(int i= 0; i<n-1; i++)
            {
                railroadCount += (array2D[i, 2] - array2D[i, 1] + 1);
            }
            int squareCount = m * n;
            lampostCount = squareCount - railroadCount;
            Console.WriteLine(lampostCount);
            Console.ReadLine();

        }
    }
}
