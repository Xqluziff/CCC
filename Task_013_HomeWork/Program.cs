/*Напишите программу, которая принимает на вход
 трёхзначное число и на выходе показывает
вторую цифру этого числа. 
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите 3x значное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 999) Console.WriteLine(SecondDigit(number));
else Console.WriteLine("Не корректное число");
   
int SecondDigit(int number)
{
    return (number / 10) % 10;
}


