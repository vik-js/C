// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] PrintMultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  for (int i = 0; i < matrix2.GetLength(1); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        matrix[j, i] += matrix1[j, k] * matrix2[k, i];
      }
    }
  }
  return matrix;
}

Console.WriteLine("Введите количество строк Матрицы 1: ");
int rowsMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Матрицы 1: ");
int columnsMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк Матрицы 2: ");
int rowsMatrix2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Матрицы 2: ");
int columnsMatrix2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2d = CreateMatrixRndInt(rowsMatrix1, columnsMatrix1, 1, 9);
PrintMatrix(matrix2d);
Console.WriteLine();

int[,] matrix2dNew = CreateMatrixRndInt(rowsMatrix2, columnsMatrix2, 1, 9);
PrintMatrix(matrix2dNew);
Console.WriteLine();

if (matrix2d.GetLength(1) == matrix2dNew.GetLength(0))
{
  int[,] multMatrix = PrintMultiplicationMatrix(matrix2d, matrix2dNew);
  PrintMatrix(multMatrix);
  Console.WriteLine();
}
else
{
  Console.WriteLine("Количество столбцов Матрицы 1 должно совпадать с количеством строк Матрицы 2!");
}
