Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number > 0)
{
  while (count <= number)
  {
    if (count % 2 == 0)
    {
      if (count <= 2)
      {
        Console.Write($"{number} -> ");
      }
      if (count == number || (count == number - 1))
      {
        Console.Write($"{count}");
      }
      else
      {
        Console.Write($"{count},");
      }
    }
    count++;
  }
}
else
{
  Console.Write("Введите положительное число!");
}