// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите длину 1 стороны:");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 2 стороны:");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 3 стороны:");
int side3 = Convert.ToInt32(Console.ReadLine());

bool existsTriangle = IsExistsTriangle(side1, side2, side3);
Console.Write(existsTriangle ? "треугольник существует" : "треугольник НЕ существует");
Console.WriteLine();

bool IsExistsTriangle(int a, int b, int c)
{
  return a < b + c && b < a + c && c < b + a;
}

