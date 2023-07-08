// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
  double[] arr = new double[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.NextDouble() * (max - min) + min;
  }
  return arr;
}

void PrintArrayDouble(double[] arr, string sep = ", ", int round = 2)
{
  for (int i = 0; i < arr.Length; i++)
  {
    double num = Math.Round(arr[i], round);
    if (i < arr.Length - 1) Console.Write($"{num}{sep}");
    else Console.Write($"{num}");
  }
}

double GetMinElem(double[] arr, int round = 2)
{
  double minElem = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < minElem)
    {
      minElem = Math.Round(arr[i], round);
    }
  }
  return minElem;
}

double GetMaxElem(double[] arr, int round = 2)
{
  double maxElem = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > maxElem)
    {
      maxElem = Math.Round(arr[i], round);
    }
  }
  return maxElem;
}

double GetDiffMaxMinElem(double maxElem, double minElem)
{
  double diffMaxMin = maxElem - minElem;
  return diffMaxMin;
}

double[] array = CreateArrayRndDouble(5, 0, 100);
Console.Write("[");
PrintArrayDouble(array);
Console.Write("]");
Console.WriteLine();

double minElement = GetMinElem(array);
double maxElement = GetMaxElem(array);
double getDiffMaxMinElem = GetDiffMaxMinElem(maxElement, minElement);
Console.Write($"Разница между макс и мин элементами => {maxElement} - {minElement} = {getDiffMaxMinElem}");
Console.WriteLine();