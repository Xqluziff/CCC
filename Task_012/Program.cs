/*14. Напишите программу, которая принимает
 на вход число и проверяет,
  кратно ли оно одновременно 7 и 23.
   14 -> нет 
   46 -> нет
161 -> да */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


bool Multiplicity(int multipleNum, int num1, int num2)
{
    return (multipleNum % num1 == 0) && (multipleNum % num2 == 0);
}

Console.WriteLine(Multiplicity(number,7,23) ? "Да":"Нет");

