﻿// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
  double[,] matrix = new double[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = (double)Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],5} ");
    }
    Console.WriteLine("|");
  }
}

Console.WriteLine("Введите m - количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n - количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = CreateMatrixRndDouble(m, n, -10, 10);

PrintMatrix(array2d);
Console.WriteLine();
