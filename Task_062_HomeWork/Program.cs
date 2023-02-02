/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите натуральные число M и N ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM <= 0 || numberN <= 0) Console.WriteLine("Числа не натуральны");
else
{
    int sumRange = SumRange(numberM, numberN);
    Console.WriteLine(sumRange);
}

int SumRange(int numM, int numN)
{
    if (numM == numN) return numM;
    else if  (numM > numN) return numM + SumRange(numM - 1, numN);
    else return numM + SumRange(numM + 1, numN);
}



