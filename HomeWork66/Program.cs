// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumDigitsFromTo(int num1, int num2)
{
  if (num2 == num1 - 1) return 0;
  return num2 + SumDigitsFromTo(num1, num2 - 1); // 4, 8 -> 4, 7 -> 4, 6 -> ... -> 4, 4
}

if (numberM > numberN)
{
  Console.WriteLine($"M = {numberM}; N = {numberN} -> {SumDigitsFromTo(numberN, numberM)}");
}
else
{
  Console.WriteLine($"M = {numberM}; N = {numberN} -> {SumDigitsFromTo(numberM, numberN)}");
}