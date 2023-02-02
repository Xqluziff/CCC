/*
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"


Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9


Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*Console.WriteLine("Введите значения M и N");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());*/

/*Naturale(number);
void Naturale(int num)
{
    if(num == 0) return;
    Naturale(num - 1); 
    Console.Write($"{num} ");
}*/

/*Diapason(1, 5);
void Diapason(int uM, int uN)
{
    if (uM == uN) Console.WriteLine(uM);
    if (uM < uN)
    {
        Console.Write(uM + " ");
        Diapason(uM + 1, uN);
    }
    if (uM > uN)
    {
        Console.Write(uM + " ");
        Diapason(uM - 1, uN);   
    }
}*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));

int SumDigits(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumDigits(num / 10);
}

// 3 + ? 9
// 5 + ? 4
// 4 + 0

//5 * ? 125
//5 * ? 5
//5 * ? retutn 1 