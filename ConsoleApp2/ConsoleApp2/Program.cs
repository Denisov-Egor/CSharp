using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        try
        {
            string[] lines = File.ReadAllLines(inputFile);
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine($"{i + 1:D3}: {lines[i]}");
                }
            }
            Console.WriteLine("Готово. Результат в output.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл input.txt не найден.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
