/*
Напишите цикл, который принимает на вход два числа
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16


*/

Console.WriteLine("Введите число А");
int digit = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число В");
int digree = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(RaiseDegree(digit, digree));

int RaiseDegree(int num, int dgr)
{
    int result = 1;
    for (int i = 0; i < dgr; i++)
    {
        result *= num;
    }

    return result;
}