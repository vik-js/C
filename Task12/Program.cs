﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int multiplicity = firstNumber % secondNumber;
if (multiplicity == 0)
{
  Console.WriteLine("Первое число кратно второму");
}
else
{
  Console.WriteLine($"Первое число НЕ кратно второму, остаток -> {multiplicity}");
}




