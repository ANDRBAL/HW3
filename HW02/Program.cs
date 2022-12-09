Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumNum(num);
Console.WriteLine($"Сумма: {sum} ");
int SumNum(int a)
{
while (a > 0)
{
um = sum + a % 10;
    a = a / 10;
}
    return sum;
}



























///Урок 3
//Console.WriteLine("\n Введите число");
//int x1 = Coordinate("x", "A");
//int y1 = Coordinate("y", "A");
//int z1 = Coordinate("z", "A");
//int x2 = Coordinate("x", "B");
//int y2 = Coordinate("y", "B");
//int z2 = Coordinate("z", "B");
//int Coordinate(string coorName, string pointName)
//{
//Console.Write($"Введите координату {coorName} точки {pointName}: ");
//return Convert.ToInt16(Console.ReadLine());
//}
//double Decision(double x1, double x2, 
//double y1, double y2, 
//double z1, double z2){
//return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//Math.Pow((y2-y1), 2) + 
//Math.Pow((z2-z1), 2));
//}

//double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

//Console.WriteLine($"Длина отрезка  {segmentLength}");


































///Урок 2
///Console.Write("Введи число: ");
///
///int a = Convert.ToInt32(Console.ReadLine());
///string b = Convert.ToString(a);
///
///if (b.Length > 2){
///  Console.WriteLine("3я цифра -> " + b[2]);
///}
///
///else {
///  Console.WriteLine("-> 3я цифра отсутсвует");
///}