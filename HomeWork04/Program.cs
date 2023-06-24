Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
  max = b;
  if (max < c)
  {
    max = c;
    Console.WriteLine($"{a}, {b}, {c} -> {max}");
  }
  else
  {
    Console.WriteLine($"{a}, {b}, {c} -> {max}");
  }
}
else if (max < c)
{
  max = c;
  Console.WriteLine($"{a}, {b}, {c} -> {max}");
}
else
{
  Console.WriteLine($"{a}, {b}, {c} -> {max}");
}


// if (max > b)
// {
//   if (max > c)
//   {
//     Console.WriteLine($"{a}, {b}, {c} -> {max}");
//   }
//   else
//   {
//     max = c;
//     Console.WriteLine($"{a}, {b}, {c} -> {max}");
//   }
// }
// else
// {
//   max = b;
//   if (max > c)
//   {
//     Console.WriteLine($"{a}, {b}, {c} -> {max}");
//   }
//   else
//   {
//     max = c;
//     Console.WriteLine($"{a}, {b}, {c} -> {max}");
//   }
// }