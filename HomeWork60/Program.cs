// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3dMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
  int[,,] matrix = new int[rows, columns, depth];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = rnd.Next(min, max + 1);
      }
    }
  }
  return matrix;
}

void Print3dMatrixWithIndex(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.WriteLine();
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write($"{matrix[i, j, k],3}({i},{j},{k})");
      }
    }
  }
}

int[,,] matrix3d = Create3dMatrixRndInt(2, 2, 2, 20, 90);
Print3dMatrixWithIndex(matrix3d);
Console.WriteLine();