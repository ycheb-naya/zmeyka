using System;

class Task
{
    static int GetN()
    {
        int n;
        while (true)
        {
            Console.WriteLine("N:");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= 100)
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("ошибка! n введен неверно. Введите число не больше 100.");
                }
            }
            else
            {
                Console.WriteLine("ошибка! Введен неверный формат числа. Введите целое число.");
            }
        }
    }

    static void Print(int[,] array, int n, int m, string name)
    {
        Console.WriteLine(name + ": ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }
    }

    static void Main(string[] args) 
    {
        int n = GetN();
        int m = n;
        int[,] a = new int[n, m];

        int value = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = value;
                    value++;
                }
            }
            else
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    a[i, j] = value;
                    value++;
                }
            }
        }

        Print(a, n, m, "A");
        Console.ReadKey(); 
    }
}