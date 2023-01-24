/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Ведите числа через пробел");
string userStr = Console.ReadLine();

int[] arrey = RedefinitionToInt(userStr);
int countElem = CountPositivElem(arrey);
Console.WriteLine($"Количество элементов >0 : {countElem}");

int[] RedefinitionToInt(string str)
{
    string[] masStr = str.Split();
    int[] masInt = Array.ConvertAll(masStr, s => int.Parse(s));
    return masInt;
}

int CountPositivElem(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) count++;
    }
    return count;
}

