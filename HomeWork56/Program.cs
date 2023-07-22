// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] GetSumOfRows(int[,] matrix)
{
  int[] sum = new int[matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int rowsum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      rowsum += matrix[i, j];
    }
    sum[i] = rowsum;
    Console.WriteLine($"Строка {i + 1} -> сумма: {rowsum}");
  }
  return sum;
}

int GetMinIndex(int[] arr)
{
  int minValue = arr[0];
  int indexOfMinRow = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < minValue)
    {
      minValue = arr[i];
      indexOfMinRow = i + 1;
    }
  }
  return indexOfMinRow;
}

int[,] matrix2d = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(matrix2d);
Console.WriteLine();

int[] matrixSumOfRows = GetSumOfRows(matrix2d);
int minSumRowElem = GetMinIndex(matrixSumOfRows);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой: {minSumRowElem}");
Console.WriteLine();
