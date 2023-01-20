/*

*/

Console.WriteLine("1 число");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 число");
int digit2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3 число");
int digit3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Proverka(digit1,digit2,digit3));


bool Proverka(int dig1, int dig2, int dig3)
{   

    if(dig1<= dig2 + dig3)
    {
        if(dig2<= dig1 + dig3)
        {
            if(dig3<= dig2 + dig1) return true;

        }
    }
    return false;
}




