/*
Напишите цикл, который принимает на вход два числа
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16


*/

Console.WriteLine("Введите число А");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int degree = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(RaiseDegree(digit, degree));

int RaiseDegree(int num, int dgr)
{
    if (dgr < 0) dgr = -dgr;
    int result = 1;
    for (int i = 0; i < dgr; i++)
    {
        result *= num;
    }

    return result;
}