///Урок 3
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube){
int counter = 0;
int length = cube.Length;
while (counter <  length){
cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
counter++;
}
}
void PrintArry(int[] coll){
int count = coll.Length;
int index = 0;
while(index < count){
Console.Write(coll[index]+ " ");
index++;
}
} 
int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);





























///Урок 2 
///Console.Write("Введи цифру, обозначающую день недели от 1 до 7: ");
///int day = Convert.ToInt32(Console.ReadLine());
///
///if (day == 6 || day == 7) {
///  Console.WriteLine("это выходной день");
///  }
///
///    else Console.WriteLine("это будний день");



