using System;

namespace Gridland_Metro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] input = new int[,]
            {
                { 4, 4, 3 },
                { 2, 2, 3 },
                { 3, 1, 4 },
                { 4, 4, 4 },
            };

            Console.WriteLine("The number of Lampposts that can be installed is: " + lamppostsCalculator(input));
            

            static int lamppostsCalculator(int[,] input)
            {
                var n = input[0, 0];
                var m = input[0, 1];
                var k = input[0, 2];

                int[,] matrix = new int[n, m];

                var i = 0;
                var j = 0;
                var row = 0;
                var start = 0;
                var end = 0;                
                var lampposts = 0;
                var trackNumber = 1;

                for (i = 1; i <= k; i++)
                {
                    row = input[i, 0] - 1;
                    start = input[i, 1] - 1;
                    end = input[i, 2] - 1;

                    for (j = start; j <= end; j++)
                    {
                        matrix[row, j] = trackNumber;
                    }

                    trackNumber++;
                }
                                
                Console.WriteLine("The final Matrix will look like this where 0 is all the lampposts spaces available:");

                for (i = 0; i < matrix.GetLength(0); i++)
                {
                    for (j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                foreach (var index in matrix)
                {
                    if (index == 0)
                    {
                        lampposts++;
                    }
                }

                return lampposts;

            }

        }
    }
}
