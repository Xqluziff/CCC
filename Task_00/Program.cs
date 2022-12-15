/*Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int res = x * 2;

System.Console.WriteLine($"Квадрат числа {x} = {res}");
