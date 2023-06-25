int number = new Random().Next(100, 1000); // 999 + 1

int firstDigit = number / 100;
int lastDigit = number % 10; 
int result = firstDigit * 10 + lastDigit;

Console.WriteLine($"Случайное число от 100 - 999 -> {number}");
Console.WriteLine($"Итоговое число без второй цифры -> {result}");



// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98