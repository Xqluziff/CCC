
Console.Clear();


int Xa = 75, Ya = 1,
    Xb = 1, Yb = 50,
    Xc = 150, Yc = 50;
/*Console.SetCursorPosition(Xa,Ya);
Console.WriteLine("+");

Console.SetCursorPosition(Xb,Yb);
Console.WriteLine("+");

Console.SetCursorPosition(Xc,Yc);
Console.WriteLine("+");*/
 


int x = Xa, y = Xb, count = 0;

Console.SetCursorPosition(x,y);
System.Console.WriteLine("+");

while(count < 1000000)
{
    int w = new Random().Next(0,3);
    if(w == 0){

        x= (x+Xa)/2;
        y= (y+Ya)/2;
    }

     if(w == 1){

        x= (x+Xb)/2;
        y= (y+Yb)/2;
    }

     if(w == 2){

        x= (x+Xc)/2;
        y= (y+Yc)/2;
     } 
    Console.SetCursorPosition(x,y);
    System.Console.WriteLine("+");
    count++;
}    

