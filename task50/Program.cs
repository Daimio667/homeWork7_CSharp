// Task 50 : Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = 5;
int columns = 5;
int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.Write("Enter first index : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second index : ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > rows && b > columns)
    Console.WriteLine("no such index exists in the array");
else
{
    object searchNumber = array.GetValue(a, b);
    Console.Write($"Number by given criteria : {searchNumber}");
}
