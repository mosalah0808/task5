using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов n");
            int n = int.Parse(Console.ReadLine());
            if ( n % 2 != 0 )
            {
                Console.WriteLine("Ошибка...n должно быть четным и больше или равным 2...");
                return;
            }

            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }
                     
            for (int i = 0, v = n / 2; v-- > 0; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    arr[i][j] = arr[j][i] =  arr[n - 1 - i][j] =  arr[j][n - 1 - i] = v; 
                }
            }

            // Вывод массива на экран
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i][ j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
