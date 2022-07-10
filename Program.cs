long ind=99999999999999999, count=1;
while (count>ind) {
Console.Write("Введите три числа: ");
int a=Convert.ToInt32(Console.ReadLine()), 
    b=Convert.ToInt32(Console.ReadLine()), 
    c=Convert.ToInt32(Console.ReadLine()), 
    max;
if (a>b) 
{ max=a; 
    if (a<c) 
    { max=c; } }
else 
{ max=b; 
    if (b<c) 
    { max=c; } }
count++;

Console.Write("Число ");
Console.Write(max);
Console.Write(" наибольшее среди других чисел множества");
Console.Write(" ; ");
}