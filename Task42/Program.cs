// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.WriteLine("Введите положительное целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int decToBin = DecToBin(number);
Console.Write(decToBin);
Console.WriteLine();

string decToBinStr = DecToBinStr(number);
Console.Write(decToBinStr);
Console.WriteLine();

int DecToBin(int num)
{
  int result = 0;
  int factor = 1;
  while (num != 0)
  {
    result = result + num % 2 * factor;
    num /= 2;
    factor *= 10;
  }
  return result;
}

string DecToBinStr(int num)
{
  string result = string.Empty;
  while (num != 0)
  {
    result = num % 2 + result;
    num /= 2;
  }
  return result;
}