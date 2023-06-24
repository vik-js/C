Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int evenNumber = a % 2;
if (evenNumber == 0)
{
  Console.WriteLine($"Число является чётным? {a} -> да");
}
else
{
  Console.WriteLine($"Число является чётным? {a} -> нет");
}
