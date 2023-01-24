/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("ВВедите  b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите  k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите  b2");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите  k2");
float k2 = Convert.ToInt32(Console.ReadLine());

float GetX(float x1, float y1, float x2, float y2)
{
    float x = (x2 - x1) / (y1 - y2);
    return x;
}

float GetY(float x, float x1, float y1)
{
    float y = y1 * x + x1;
    return y;
}

void PrintPoint(float ux, float uy)
{
    Console.WriteLine($"Точка пресечения {ux};{uy}");
}

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    float x = GetX(b1, k1, b2, k2);
    float y = GetY(x, b1, k1);
    PrintPoint(x, y);
}


