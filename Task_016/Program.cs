/*Напишите программу, которая принимает на вход
 координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
  выдаёт номер четверти плоскости, в которой
   находится эта точка.*/

System.Console.WriteLine("Введите координаты точки ");
System.Console.WriteLine("X: ");
int x = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите координаты точки ");
System.Console.WriteLine("Y: ");
int y = Convert.ToInt32(System.Console.ReadLine());

int quarter = Querter(x, y);
string res = quarter > 0 ? $" координвты {quarter}" : "Не корректные данные";
System.Console.WriteLine(res);

int Querter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;


}