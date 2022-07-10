int numa = 5, numb = 8;
int starta = 1;
int startb = 1;
while (starta <= numa)
{
    if (starta % 2 == 0) {
        Console.Write(starta);
        } else {Console.Write("");
        }
    starta++;
}
Console.Write(" AND ");
while (startb <= numb)
{
    if (startb % 2 == 0) {
    Console.Write(startb);
        } else {Console.Write("");
        }
    startb++;
}
