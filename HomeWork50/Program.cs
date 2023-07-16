// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void PrintElemByIndex(int[,] matrix, int i, int j)
{
  if (i - 1 < matrix.GetLength(0) && j - 1 < matrix.GetLength(1))
  {
    Console.WriteLine($"{i},{j} -> {matrix[i - 1, j - 1]}");
  }
  else
  {
    Console.WriteLine($"{i},{j} -> такого элемента нет в массиве");
  }
}

Console.WriteLine("Введите номер строки: ");
int rowI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columnJ = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(5, 7, 1, 20);

Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();

PrintElemByIndex(array2d, rowI, columnJ);
