﻿Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;
while (count <= number)
{
  Console.Write($"{count} ");
  count++;

}



// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"