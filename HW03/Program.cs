﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}































































//Console.WriteLine("введите количество строк");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите количество столбцов");
//int m = Convert.ToInt32(Console.ReadLine());

//int[,] numbers = new int[n, m];
//FillArrayRandomNumbers(numbers);
//
//
//for (int j = 0; j < numbers.GetLength(1); j++)
//{
//    double avarage = 0;
//    for (int i = 0; i < numbers.GetLength(0); i++)
//    {
//        avarage = (avarage + numbers[i, j]);
//    }
//    avarage = avarage / n;
//    Console.Write(avarage + "; ");
//}
//Console.WriteLine();
//PrintArray(numbers);
//
//

//void FillArrayRandomNumbers(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(0, 10);
  //      }
   // }
//}
//
//void PrintArray(int[,] array)
//{
//
  //  for (int i = 0; i < array.GetLength(0); i++)
   // {
     //   Console.Write("[ ");
     //   for (int j = 0; j < array.GetLength(1); j++)
      //  {
     //       Console.Write(array[i, j] + " ");
      //  }
     //   Console.Write("]");
     //   Console.WriteLine("");
    //}
//}















































//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//double[] numbers = new double[size];
//FillArrayRandomNumbers(numbers);
//Console.WriteLine("Вот наш массив: ");
//PrintArray(numbers);
//double min = Int32.MaxValue;
//double max = Int32.MinValue;
//
//for (int a = 0; a < numbers.Length; a++)
//{
//if (numbers[a] > max)
//{
//            max = numbers[a];
// }
//if (numbers[a] < min)
//{
//            min = numbers[a];
// }
//}
//
//Console.WriteLine($"всего {numbers.Length} чисел. Макс= {max}, мин значение = {min}");
//Console.WriteLine($"Разница между макс и мин = {max - min}");
//
//void FillArrayRandomNumbers(double[] numbers)
//{
// for(int i = 0; i < numbers.Length; i++)
// {
//            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//}
//}
//void PrintArray(double[] numbers)
//{
// Console.Write("[ ");
//for(int i = 0; i < numbers.Length; i++)
// {
// Console.Write(numbers[i] + " ");
//}
// Console.Write("]");
// Console.WriteLine();
//}
































//int[] arr1 = new int[8];
//for (int i = 0; i < 8; i++)
//{
// arr1[i] = new Random().Next(1, 11);
//}
//Console.Write($"Элементы массива: ");
//for (int i = 0; i < 8; i++)
//{
 //   Console.Write($"{arr1[i]} ");
//}
//string arr = string.Join(",", arr1);
//Console.WriteLine();
//Console.Write($"Элементы массива: ");
///Console.WriteLine($"{arr} ");






















///Урок 3
//Console.Write("Введите число: ");
//int cube = Convert.ToInt32(Console.ReadLine());
//void Cube(int[] cube){
//int counter = 0;
//int length = cube.Length;
//while (counter <  length){
//cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//counter++;
//}
//}
//void PrintArry(int[] coll){
//int count = coll.Length;
//int index = 0;
//while(index < count){
//Console.Write(coll[index]+ " ");
//index++;
//}
//} 
//int[] arry = new int[cube+1];
//Cube(arry);
//PrintArry(arry);





























///Урок 2 
///Console.Write("Введи цифру, обозначающую день недели от 1 до 7: ");
///int day = Convert.ToInt32(Console.ReadLine());
///
///if (day == 6 || day == 7) {
///  Console.WriteLine("это выходной день");
///  }
///
///    else Console.WriteLine("это будний день");



