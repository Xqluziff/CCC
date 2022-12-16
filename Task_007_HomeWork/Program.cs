/*: Напишите программу, которая на вход принимает число
 и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

System.Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

if(value%2==0)System.Console.WriteLine($"Число {value} четное");
else System.Console.WriteLine($"Число {value} не чётное");