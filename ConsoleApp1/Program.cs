using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация
            Console.WriteLine("Введите n");
            int n = Int32.Parse(Console.ReadLine());
            int[][] graphMatrix = new int[n][];

            //Ввод матрицы графа
            Console.WriteLine("Введите матрицу");
            for (int i = 0; i < n; i++)
            {
                string arrowString = Console.ReadLine();
                string[] arr = arrowString.Split(' ');
                graphMatrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    graphMatrix[i][j] = Int16.Parse(arr[j]);
                }
            }
            ShowMatrix(graphMatrix, n);



            Console.ReadLine();
        }

        private static void ShowMatrix(int[][] graphMatrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(graphMatrix[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
