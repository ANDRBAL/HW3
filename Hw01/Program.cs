int n = InputInt("Введите положительное число");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}






































//Console.Clear();
//Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
//Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");
//int range = InputNumbers("Введите диапазон: от 1 до ");
//
//int[,] array = new int[m, n];
///CreateArray(array);
//WriteArray(array);

//Console.WriteLine($"\nОтсортированный массив: ");
//OrderArrayLines(array);
//WriteArray(array);
//
//void OrderArrayLines(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
 // {
 //   for (int j = 0; j < array.GetLength(1); j++)
//    {
 //     for (int k = 0; k < array.GetLength(1) - 1; k++)
 //     {
  //      if (array[i, k] < array[i, k + 1])
   //     {
    //      int temp = array[i, k + 1];
     //     array[i, k + 1] = array[i, k];
      //    array[i, k] = temp;
  //      }
  //    }
 //   }
 // }
//}

//int InputNumbers(string input)
//{
//  Console.Write(input);
//  int output = Convert.ToInt32(Console.ReadLine());
//  return output;
//}

//void CreateArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i, j] = new Random().Next(range);
//    }
//  }
//}

//void WriteArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//  }
//}

































































//Console.WriteLine("введите количество строк");
//int linesVol = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int columnsVol = Convert.ToInt32(Console.ReadLine());
//double[,] numbers = new double[linesVol, columnsVol];
//FillArrayRandomNumbers(numbers);
//PrintArray(numbers);
//
//void FillArrayRandomNumbers(double[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//        }
//    }
//}
//
//void PrintArray(double[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
 //       Console.Write("[ ");
 //       for (int j = 0; j < array.GetLength(1); j++)
  //      {
   //         Console.Write(array[i, j] + " ");
   //     }
    //    Console.Write("]");
    //    Console.WriteLine("");
    //}
//}





























//Console.Write($"Введите количество чисел: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//CheckNumbers(num);
//Console.Write($"Пользователь ввел {count} положительных чисел");
//int CheckNumbers(int a)
//{
//for (int i = 1; i <= a; i++)
//{
//Console.Write($"Введите  число {i} : ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num > 0) count++;
//Console.WriteLine();
//}
//return count;
//}


























//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.WriteLine("Наш массив: ");
//PrintArray(numbers);
//int count = 0;

//for (int a = 0; a < numbers.Length; a++)
//if (numbers[a] % 2 == 0)
//count++;

//Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

//void FillArrayRandomNumbers(int[] numbers)
//{
//for(int i = 0; i < numbers.Length; i++)
//{
//numbers[i] = new Random().Next(100,1000);
//}
//}
//void PrintArray(int[] numbers)
//{
//    Console.Write("[ ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//   }
//    Console.Write("]");
//    Console.WriteLine();
//}































//Console.Write("Введите число: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int result = 1;
//for (int i = 1; i <= num2; i++)
//{
//   result = result * num1;
//}
//Console.WriteLine(result);




























///Урок 3
//Console.Write("Введите 5ти значное число: ");
//string? number = Console.ReadLine();
//void CheckingNumber(string number){
//if (number[0]==number[4] || number[1]==number[3]){
//Console.WriteLine($"Это число: {number} - палиндром.");
//}
//else Console.WriteLine($"Это число: {number} - Не палиндром.");
//}
//if (number!.Length == 5){
//CheckingNumber(number);
//}
//else Console.WriteLine($"Не правильное число");











































///Урок 2
///Console.Write("Введи трёхзначное число: ");
///
///int a = Convert.ToInt32(Console.ReadLine());
///string b = Convert.ToString(a);
///
///Console.WriteLine("вторая цифра этого числа -> "+b[1]);