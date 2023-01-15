/*
 Напишите программу, которая принимает на вход число N
  и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */



Console.WriteLine("Enter digit");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Fakt2(number));

int Fakt(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }

    return mult;
}

int Fakt2(int n)
{
    if (n <= 1) return 1;
    return n * Fakt2(n - 1);
}
/*
    5 * 24
    4 * 6
    3 * 2
    2 * 1
    1 * 1
*/



