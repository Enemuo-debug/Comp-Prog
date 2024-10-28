using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitive_Programming
{
    public class Islands
    {
        public static int ClearAllLand(List<List<int>> matrix)
        {
            int numberOfIslands = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        numberOfIslands++;
                        try
                        {
                            ConvertToWater(matrix, i, j);
                            ConvertToWater(matrix, i + 1, j);
                            ConvertToWater(matrix, i - 1, j);
                            ConvertToWater(matrix, i, j + 1);
                            ConvertToWater(matrix, i, j - 1);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
            return numberOfIslands;
        }

        public static void ConvertToWater(List<List<int>> matrix, int i, int j)
        {
            if (i >= 0 && i < matrix.Count && j >= 0 && j < matrix[0].Count && matrix[i][j] == 1)
            {
                matrix[i][j] = 0;
                ConvertToWater(matrix, i + 1, j);
                ConvertToWater(matrix, i - 1, j);
                ConvertToWater(matrix, i, j + 1);
                ConvertToWater(matrix, i, j - 1);
            }
        }

        public static void Main(string[] args)
        {
            List<List<int>> Shore = new List<List<int>> {
                new List<int> {1, 0, 1, 0, 1},
                new List<int> {0, 0, 0, 0, 1},
                new List<int> {1, 0, 0, 0, 1}
            };

            Console.WriteLine(ClearAllLand(Shore));
        }
    }
}

/*
    CEOnly 2024
    LeetCode Question
*/