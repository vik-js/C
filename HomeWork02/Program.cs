Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
}
else if (b > a)
{
  Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
}
else 
{
  Console.WriteLine($"a = {a}; b = {b} -> числа равны");
}
