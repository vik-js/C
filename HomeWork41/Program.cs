// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целое число: ");
int arrNumber = Convert.ToInt32(Console.ReadLine());

int[] greaterZeroArr = GreaterZeroArr(arrNumber);
PrintArray(greaterZeroArr);
Console.WriteLine();

int countGreaterZeroArr = CountGreaterZeroArr(greaterZeroArr);
Console.WriteLine(countGreaterZeroArr);

int[] GreaterZeroArr(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  {
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
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

int CountGreaterZeroArr(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      count++;
    }
  }
  return count;
}
