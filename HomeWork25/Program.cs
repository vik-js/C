// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetExponentiate(int num, int degree)
{
  int result = 1;
  for (int i = 0; i < degree; i++)
  {
    result = result * num;
  }
  return result;
}

bool ValidExp(int degree)
{
  if (degree < 0)
  {
    Console.WriteLine("Степень не должна быть меньше нуля");
    return false;
  }
  return true;
}

int getExponentiate = GetExponentiate(number1, number2);

if (ValidExp(number2))
{
  Console.WriteLine($"{number1}, {number2} -> {getExponentiate}");
}

