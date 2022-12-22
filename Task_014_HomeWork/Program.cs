/*Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет. 
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;


if (number > 99)
{
    int res = ThirdDigit(number);
    Console.WriteLine(res);

}
else Console.WriteLine("3 цифры нет");

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}
