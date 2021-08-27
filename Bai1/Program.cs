using System;

namespace MaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix();
            int max = FindMax(matrix);
            Console.WriteLine($"Max value in matrix is: {max}");
            Console.WriteLine($"Tam giac duoi cua matrix:");
            ShowMatrix(matrix);
        }

        public static int[,] CreateMatrix()
        {
            Console.WriteLine($"Enter number of rows in matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number of collumns in matrix: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value of matrix[{i},{j}]");
                    int value = int.Parse(Console.ReadLine());
                    matrix[i, j] = value;
                }
            }
            return matrix;
        }
        public static int FindMax(int[,] matrix)
        {
            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        public static void ShowMatrix(int[,] matrix)
        {
                for(int i=0; i< matrix.GetLength(0); i++){
                    for(int j=0; j<=i; j++){
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine();
            }
        }
    }

}
