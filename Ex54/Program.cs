// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//int[,] arr = new int[3, 5];
int[,] FillArray(int m, int n)  //Заполняет массив
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

int[,] SortArray(int[,] arr)    //сортирует строки массива по убыванию
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int j1 = 0; j1 < arr.GetLength(1) - 1; j1++)
            {
                if (arr[i, j1 + 1] > arr[i, j1])
                {
                    int max = arr[i, j1 + 1];
                    arr[i, j1 + 1] = arr[i, j1];
                    arr[i, j1] = max;
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[,] arr)         //Печать массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(3, 5);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);