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

double GetMinElem(double[] arr)
{
  double minElem = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < minElem)
    {
      minElem = arr[i];
    }
  }
  return minElem;
}

double GetMaxElem(double[] arr)
{
  double maxElem = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > maxElem)
    {
      maxElem = arr[i];
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

double minElement = Math.Round(GetMinElem(array), 2);
double maxElement = Math.Round(GetMaxElem(array), 2);
double getDiffMaxMinElem = Math.Round(GetDiffMaxMinElem(maxElement, minElement), 2);
Console.Write($"Разница между макс и мин элементами => {maxElement} - {minElement} = {getDiffMaxMinElem}");
Console.WriteLine();