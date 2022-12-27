/*
Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;
if (number > 9999 && number < 100000) Console.WriteLine(Polydrome(number) ? "Yas" : "No");
else System.Console.WriteLine("No valid data");

bool Polydrome(int num)
{
    int numTail = num % 10;
    int numHead = num / 10000;

    if (numTail == numHead)
    {
        numTail = num / 10 % 10;
        numHead = num / 1000 % 10;
        if (numTail == numHead) return true;
    }
    return false;
}
