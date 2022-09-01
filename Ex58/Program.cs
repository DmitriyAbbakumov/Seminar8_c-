// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix(int m, int n, int a, int b)   //Заполняем матрицу
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b);
        }
    }
    return array;
}

void PrintArray(int[,] array)       //печатает матрицу
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixMult(int[,] matr1, int[,] matr2)        //умноженние матриц
{
    int[,] matrMult = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matrMult.GetLength(0); i++)
    {
        for (int j = 0; j < matrMult.GetLength(1); j++)
        {
            int P = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                P = P + matr1[i, k] * matr2[k, j];

            }
            matrMult[i, j] = P;
        }
    }
    return matrMult;
}
Console.WriteLine("Введите через Enter строки и столбцы первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите через Enter строки и столбцы второй матрицы (столбцы первой матрицы долны равняться строкам второй): ");
int m2 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите через Enter диапазон элементов матриц: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = matrix(m1, n1, x, y);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = matrix(m2, n2, x, y);
PrintArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("умножение невозможно");
}
else
{
    int[,] matrixMult3 = matrixMult(matrix1, matrix2);
    PrintArray(matrixMult3);
}



