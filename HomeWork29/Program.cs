// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива: ");
int arrNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное значение массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] arr, string sep = ", ")
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
    else Console.Write($"{arr[i]}");
  }
}

int[] array = CreateArrayRndInt(arrNumber, minNumber, maxNumber);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();