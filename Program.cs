int a1=2, b1=3, c1=7, 
    a2=44, b2=5, c2=78, 
    a3=22, b3=3, c3=9, 
    max1, max2, max3;
if (a1>b1) 
{ max1=a1; 
    if (a1<c1) 
    { max1=c1; } }
else 
{ max1=b1; 
    if (b1<c1) 
    { max1=c1; } }

if (a2>b2) 
{ max2=a2; 
    if (a2<c2) 
    { max2=c2; } }
else 
{ max2=b2; 
    if (b2<c2) 
    { max2=c2; } }

if (a3>b3) 
{ max3=a3; 
    if (a3<c3) 
    { max3=c3; } }
else 
{ max3=b3; 
    if (b3<c3) 
    { max3=c3; } }
Console.Write("Число ");
Console.Write(max1);
Console.Write(" наибольшее среди других чисел первого множества");
Console.Write(" ; ");

Console.Write("Число ");
Console.Write(max2);
Console.Write(" наибольшее среди других чисел второго множества");
Console.Write(" ; ");

Console.Write("Число ");
Console.Write(max3);
Console.Write(" наибольшее среди других чисел третьего множества");
Console.Write(" ; ");