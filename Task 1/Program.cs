/* Задача 1: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */
Console.Write("Укажите количество строк в массиве, m: ");
string rows = Console.ReadLine();
int m = int.Parse(rows);
Console.Write("Укажите количество столбцов в массиве, n: ");
string columns = Console.ReadLine();
int n = int.Parse(columns);
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rand.NextDouble();
        Console.Write($"{array[i, j]:f2} \t");
    }
    Console.WriteLine();
}
