Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= num2; i++)
{
    result = result * num1;
}
Console.WriteLine(result);




























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