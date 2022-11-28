Console.Write("Введи цифру, обозначающую день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

  if (day == 6 || day == 7) {
  Console.WriteLine("это выходной день");
  }

    else Console.WriteLine("это будний день");



