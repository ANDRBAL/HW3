Console.Write("Введи число: ");

int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);

if (b.Length > 2){
  Console.WriteLine("3я цифра -> " + b[2]);
}

else {
  Console.WriteLine("-> 3я цифра отсутсвует");
}