using System;

class Program
{
    static void Main()
    {
        Console.Write("Количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        int[][] jagged = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            int len = rnd.Next(3, 11); 
            jagged[i] = new int[len];
            for (int j = 0; j < len; j++)
                jagged[i][j] = rnd.Next(1, 100);
        }

        Console.WriteLine("\nИсходный массив:");
        PrintJagged(jagged);

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - 1 - i; j++)
            {
                if (jagged[j].Length > jagged[j + 1].Length)
                {
                    int[] temp = jagged[j];
                    jagged[j] = jagged[j + 1];
                    jagged[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nОтсортированный массив (строки по возрастанию длины):");
        PrintJagged(jagged);
    }

    static void PrintJagged(int[][] arr)
    {
        foreach (var row in arr)
        {
            Console.WriteLine(string.Join(" ", row) + "  (длина " + row.Length + ")");
        }
    }
}