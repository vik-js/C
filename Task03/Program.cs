Console.WriteLine("Введите номер дня недели:");
string? dayOfWeek = Console.ReadLine();

if (dayOfWeek == "1")
{
  Console.WriteLine($"{dayOfWeek} -> Понедельник");
}
else if (dayOfWeek == "2")
{
  Console.WriteLine($"{dayOfWeek} -> Вторник");
}
else if (dayOfWeek == "3")
{
  Console.WriteLine($"{dayOfWeek} -> Среда");
}
else if (dayOfWeek == "4")
{
  Console.WriteLine($"{dayOfWeek} -> Четверг");
}
else if (dayOfWeek == "5")
{
  Console.WriteLine($"{dayOfWeek} -> Пятница");
}
else if (dayOfWeek == "6")
{
  Console.WriteLine($"{dayOfWeek} -> Суббота");
}
else if (dayOfWeek == "7")
{
  Console.WriteLine($"{dayOfWeek} -> Воскресенье");
}
else
{
  Console.WriteLine("В неделе только 7 дней =), введите число от 1 до 7");
}
