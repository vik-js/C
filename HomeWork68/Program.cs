// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if ((numberM == 5 && numberN >= 1) || (numberM == 4 && numberN >= 2) || (numberM > 5 && numberN >= 0))
{
  Console.WriteLine("Лучше ввести числа поменьше =)!");
}
else if (numberM < 0 || numberN < 0)
{
  Console.WriteLine("Введите НЕотрицательные числа!");
}
else
{
  Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {AckermanFunction(numberM, numberN)}");
}

int AckermanFunction(int num1, int num2)
{
  while (num1 != 0)
  {
    if (num2 == 0)
    {
      num2 = 1;
    }
    else
    {
      num2 = AckermanFunction(num1, num2 - 1);
    }
    num1 = num1 - 1;
  }
  return num2 + 1;
}
