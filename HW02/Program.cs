Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
Console.WriteLine(a);
}
else if (b > a && b > c)
{
Console.WriteLine(b);
}
else
{
Console.WriteLine(c);
}
