/* Задача 3: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */
Random rndRows = new Random();
Random rndColumns = new Random();
int rows = rndRows.Next(2, 3);
int columns = rndColumns.Next(2, 10);
int[,] array = new int[rows, columns];
Random rand = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(10, 1000);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
int r = 0;
double middle = 0;
for (int c = 0; c < columns; c++)
{
    middle = (array[r, c] + array[r + 1, c]) / 2.0 ;
    Console.Write($"{middle:f1} \t");
}