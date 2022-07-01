/* Задача 2: Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет. */
int rows = 2;
Random rndColumns = new Random();
int columns = rndColumns.Next(2, 10);
int[,] array = new int[rows, columns];
Random rand = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(10, 100);
        Console.Write($"{array[i, j]} \t ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию элемента массива");
Console.WriteLine("Введите номер строки элемента массива: ");
string numberOfRow = Console.ReadLine();
int nor = int.Parse(numberOfRow);
Console.WriteLine("Введите номер столбца элемента массива: ");
string numberOfColumn = Console.ReadLine();
int noc = int.Parse(numberOfColumn);

if (nor > 2 || noc > array.Length/2)
{
    Console.WriteLine("Нет элемента с такой позицией");
}
else
{
    Console.WriteLine($"{array[nor - 1, noc - 1]}");
}