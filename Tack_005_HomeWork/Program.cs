/*Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

System.Console.WriteLine("Ввделите 1 число");
int number_1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Ввделите 2 число");
int number_2 = Convert.ToInt32(Console.ReadLine());
int max= 0;

if(number_1 != number_2) 
{
    if(number_1 > number_2) max = number_1;
    else if (number_1 < number_2) max = number_2;
    System.Console.WriteLine($"Максимальеный элемент: {max}");
}
else System.Console.WriteLine("Элементы равны");





