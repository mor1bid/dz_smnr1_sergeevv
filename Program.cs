﻿int numa = 5, numb = 8;
int starta = 1;
int startb = 1;
Console.WriteLine("Чётные числа от единицы до первого числа: ");
while (starta <= numa)
{
    if (starta % 2 == 0) {
        Console.Write(starta);
        Console.Write(", ");
        } else {Console.Write("");
        }
    starta++;
}
Console.WriteLine("И от единицы до второго числа: ");
while (startb <= numb)
{
    if (startb % 2 == 0) {
    Console.Write(startb);
    Console.Write(", ");
        } else {Console.Write("");
        }
    startb++;
}
