/*Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

System.Console.WriteLine("Введите 1 число ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2 число ");
int number_1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 3 число ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (max < number_1) max = number_1;
if (max < number_2) max = number_2;

System.Console.WriteLine($"Максимальное значение {max}");












