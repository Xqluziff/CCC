/*Напишите программу, которая принимает на вход
 число (N) и выдаёт таблицу квадратов
  чисел от 1 до N. */


System.Console.WriteLine("Enter");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number > 0) TableSquer(number);
else System.Console.WriteLine("Не корректые данные");

void TableSquer(int num)
{
    int count = 1;
    while (count <= num)
    {
        //System.Console.WriteLine($"{count}\t"+Math.Pow(count,2));
        System.Console.WriteLine($"{count,1} {Math.Pow(count, 2),10}");
        count++;
    }
}