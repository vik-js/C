// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void ReplaceRowsColumns(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < i; j++)
    {
      int temp = matrix[i, j];
      matrix[i, j] = matrix[j, i];
      matrix[j, i] = temp;
    }
  }
}

bool ValidSizeMatrix(int[,] matrix)
{
  if (matrix.GetLength(0) != matrix.GetLength(1))
  {
    Console.WriteLine("В таком массиве заменить строки на столбцы нельзя!");
    return false;
  }
  return true;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9); // меняем вручную размер массива и видим сообщение об ошибке

if (ValidSizeMatrix(array2d))
{
  PrintMatrix(array2d);
  Console.WriteLine();

  ReplaceRowsColumns(array2d);
  PrintMatrix(array2d);
}
