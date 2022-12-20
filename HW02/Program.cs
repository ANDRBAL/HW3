Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}































//Console.WriteLine("введите значение b1");
//double b1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите число k1");
//double k1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите значение b2");
//double b2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите число k2");
//double k2 = Convert.ToInt32(Console.ReadLine());
//
//double x = (-b2 + b1)/(-k1 + k2);
//double y = k2 * x + b2;
//
//Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");






















































//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.WriteLine("Вот наш массив: ");
//PrintArray(numbers);
//int sum = 0;
//
//for (int a = 0; a < numbers.Length; a+=2)
//sum = sum + numbers[a];
//
//Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
//
//void FillArrayRandomNumbers(int[] numbers)
//{
//for(int i = 0; i < numbers.Length; i++)
//{
//numbers[i] = new Random().Next(1,10);
//}
//}
//void PrintArray(int[] numbers)
//{
//Console.Write("[ ");
//for(int i = 0; i < numbers.Length; i++)
//{
//Console.Write(numbers[i] + " ");
//}
//Console.Write("]");
//Console.WriteLine();
//}






























//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//SumNum(num);
//Console.WriteLine($"Сумма: {sum} ");
//int SumNum(int a)
//{
//while (a > 0)
//{
//sum = sum + a % 10;
//    a = a / 10;
//}
//    return sum;
//}



























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