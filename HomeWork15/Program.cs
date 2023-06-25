// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek > 0 && dayOfWeek <= 7)
{
  if (dayOfWeek > 5)
  {
    Console.WriteLine($"{dayOfWeek} -> да");
  }
  else
  {
    Console.WriteLine($"{dayOfWeek} -> нет");
  }
}
else
{
  Console.WriteLine("В неделе только 7 дней =), введите число от 1 до 7");
}

// if (dayOfWeek == 6 || dayOfWeek == 7)
// {
//   Console.WriteLine($"{dayOfWeek} -> да");
// }
// else if (dayOfWeek > 0 && dayOfWeek < 6)
// {
//   Console.WriteLine($"{dayOfWeek} -> нет");
// }
// else
// {
//   Console.WriteLine("В неделе только 7 дней =), введите число от 1 до 7");
// }