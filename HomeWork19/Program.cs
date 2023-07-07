// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int polydrome = Polydrome(number);
if (polydrome == number) {
    Console.WriteLine($"{number} -> да");
}
else {
    Console.WriteLine($"{number} -> нет");
}
int Polydrome(int num) {
    int num_reverse = 0;
    while (num > 0) // 486
    { 
        num_reverse = num_reverse * 10 + num % 10; // 0*10+6 0*10+8 0*10+4
        num = num / 10; // 48 4
    }
    return num_reverse;
}