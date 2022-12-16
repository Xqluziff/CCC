/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= value)
{
    System.Console.WriteLine(count+=2);
}