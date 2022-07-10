ulong ind=99999999999999999, count=1, a, b, c, max;
while (count>ind) {
Console.Write("Введите три числа: ");
a=Convert.ToUInt32(Console.ReadLine());
b=Convert.ToUInt32(Console.ReadLine()); 
c=Convert.ToUInt32(Console.ReadLine());
if (a>b) 
{ max=a; 
    if (a<c) 
    { max=c; } }
else 
{ max=b; 
    if (b<c) 
    { max=c; } }
Console.Write("Число ");
Console.Write(max);
Console.Write(" наибольшее среди других чисел множества");
Console.Write(" ; ");
count++;
}