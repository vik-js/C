int number = new Random().Next(10, 100); // 99 + 1

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
  Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}
else if (firstDigit < secondDigit)
{
  Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}
else
{
  Console.WriteLine("Цифры одинаковые");
}

Console.WriteLine($"Случайное число от 10 - 99 -> {number}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");

// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8