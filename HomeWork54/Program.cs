// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];

  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],3} ");
    }
    Console.WriteLine("|");
  }
}

int[,] SortRowsOrderBy(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      int maxPosition = j;
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
      }
      int temparr = matrix[i, j];
      matrix[i, j] = matrix[i, maxPosition];
      matrix[i, maxPosition] = temparr;
    }
  }
  return matrix;
}

int[,] matrix2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix2d);
Console.WriteLine();

PrintMatrix(SortRowsOrderBy(matrix2d));
Console.WriteLine();