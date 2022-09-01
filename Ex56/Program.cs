// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите строки в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбцы в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[] arr1 = new int[m];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    arr1[i] = sum;
    Console.Write($"{arr1[i]} ");
}
Console.WriteLine();

int min = arr1[0];
for (int i = 0; i < arr1.Length; i++)
{
    if (min > arr1[i]) min = arr1[i];
}
Console.WriteLine(min);
Console.WriteLine();

for (int i = 0; i < arr1.Length; i++)
    if (min == arr1[i]) Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i + 1} строка");