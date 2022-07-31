Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int x1 = 40, y1 = 1,
    x2 = 1, y2 = 20,
    x3 = 80, y3 = 20;

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int x = x1, y = y1;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //=[0,3) 0, 1, 2
    if(what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }

    if(what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
     if(what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x , y);
    Console.WriteLine("+");
    count = count + 1; // либо count+=1 либо count++
}

// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine();

// int xa = 1, ya = 1,
//     xb = 1, yb = 40,
//     xc = 40, yc = 40,
//     xd = 40, yd = 1;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// Console.SetCursorPosition(xd, yd);
// Console.WriteLine("+");

// int x = xa, y = yc;

// int count = 0;

// while(count < 10000)
// {
//     int what = new Random().Next(0, 3); //[0,3) 0, 1, 2
//     if(what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }

//     if(what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//      if(what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x , y);
//     Console.WriteLine("+");
//     count = count + 1; // либо count+=1 либо count++
// }