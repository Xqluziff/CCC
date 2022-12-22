/*Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, 
 является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Введите число");
 int  numberDay= Convert.ToInt32(Console.ReadLine());
  
 if (numberDay >= 1 && numberDay <= 7)
{
    if (CheckWeekend(numberDay))
    {
        Console.WriteLine("Выходной");
    }
    else Console.WriteLine("Будни");
}
else Console.WriteLine("Не корректное число");

bool CheckWeekend(int num)
{
    return num == 6 || num == 7;
}
