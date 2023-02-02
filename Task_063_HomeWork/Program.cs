/*
 Напишите программу вычисления  с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.WriteLine("Введите два неотрицательных числа");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0) Console.WriteLine("Введено отрицательное число");
else
{
    int numAkkerman = RecursAkkerman(numberM, numberN);
    Console.WriteLine($" M: {numberM} | N: {numberN} => {numAkkerman}");

}
int RecursAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return RecursAkkerman(n - 1, 1);
    return RecursAkkerman(n - 1, RecursAkkerman(n, m - 1));
}

