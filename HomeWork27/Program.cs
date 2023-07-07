// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sunNumber = SunNumber(number);
Console.WriteLine($"{number} -> {sunNumber}");

int SunNumber(int num) {
    int result = 0;
    while (num > 0) // 1234 123 12
    { 
        result = result + num % 10; // 0+4 4+3 4+3+2 4+3+2+1
        num = num / 10; // 123 12 1
    }
    return result;
}
