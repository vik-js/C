﻿Console.WriteLine("Введите 3-х значное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
  number *= -1;
}
if (number >= 100 && number <= 999)
{
  int lastNumber = number % 10;
  Console.WriteLine($"Последняя цифра числа {number}: {lastNumber}");
}
else
{
  Console.WriteLine("Введено неверное число!");
}


// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8