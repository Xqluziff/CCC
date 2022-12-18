/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= value)
{
    if(count % 2 ==0) System.Console.Write(count + "|");
count+=2;
}
System.Console.WriteLine('\n');