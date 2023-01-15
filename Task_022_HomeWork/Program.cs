/*Напишите программу, которая принимает
 на вход число (N) и выдаёт
  таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

System.Console.WriteLine("Enter digit");
double number = Convert.ToDouble(Console.ReadLine());


if (number > 0) TableSquer(number);
else System.Console.WriteLine("Не корректые данные");

void TableSquer(double num)
{
    int count = 1;
    while (count <= num)
    {
        //System.Console.WriteLine($"{count}\t"+Math.Pow(count,2));
        System.Console.WriteLine($"{count,1} {Math.Pow(count, 3),10}");
        count++;
    }
}