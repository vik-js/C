// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
  Console.Write("Число N должно быть положительным и отличным от нуля!");
}
else
{
  Console.Write($"N = {number} -> ");
  NaturalNumbersFromNtoOne(number);
}

void NaturalNumbersFromNtoOne(int num) // 5
{
  if (num != 1)
  {
    Console.Write($"{num} ");
    NaturalNumbersFromNtoOne(num - 1);
  }
  else
  {
    Console.Write($"{num} ");
  }
}
Console.WriteLine();
