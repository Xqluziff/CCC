
/*Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
 A (3,6); B (2,1) -> 5,09 
 A (7,-5); B (1,-1) -> 7,21 */

System.Console.WriteLine("Введите 1 координ");
double x1 = Convert.ToInt32(System.Console.ReadLine());
double y1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите 2 координ");
double x2 = Convert.ToInt32(System.Console.ReadLine());
double y2 = Convert.ToInt32(System.Console.ReadLine());

double res = Hypotenuse(x1,y1,x2,y2);
System.Console.WriteLine(Math.Round(res,2,MidpointRounding.ToZero) );

double Hypotenuse(double xc1,double yc1,double xc2,double yc2 )
{

double pointX = Math.Pow(xc2 - xc1,2);
double pointY = Math.Pow(yc2 - yc1,2);
double res = Math.Sqrt(pointX + pointY);

return res;
}

