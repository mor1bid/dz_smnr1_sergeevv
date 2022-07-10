ulong index=999999999999999, count=0, a, b, max, min;
while (count<=index) {
Console.WriteLine("Введите два числа:");
a=Convert.ToUInt32(Console.ReadLine());
b=Convert.ToUInt32(Console.ReadLine());
if (a>b) { max=a; min=b; }
else { max=b; min=a; }
Console.Write("Число ");
Console.Write(max);
Console.Write(" больше числа ");
Console.Write(min);
Console.Write("; ");
count++;
}
