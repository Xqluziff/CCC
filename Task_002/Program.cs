﻿/*
3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите число");
int x = Convert.ToInt32(System.Console.ReadLine());


if (x == 1)
{
    System.Console.WriteLine("Пн");
}
else if (x == 2)
{
    System.Console.WriteLine("Вт");
}
else if (x == 3)
{
    System.Console.WriteLine("Ср");
}
else if (x == 4)
{
    System.Console.WriteLine("Чт");
}
else if (x == 5)
{
    System.Console.WriteLine("Пт");
}
else if (x == 6)
{
    System.Console.WriteLine("Сб");
}
else if (x == 7)
{
    System.Console.WriteLine("Вс");
}
else
{
    System.Console.WriteLine("Не корректное значения");
}