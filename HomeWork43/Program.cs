// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;

if (ValidLines(x, y))
{
  Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

bool ValidLines(float xx, float yy)
{
  if (k1 == k2)
  {
    if (b1 == b2)
    {
      Console.WriteLine("Прямые совпадают!");
      return false;
    }
    else
    {
      Console.WriteLine("Прямые параллельны!");
      return false;
    }
  }
  return true;
}
