int numa = 5, numb = 8;
int starta = -numa;
int startb = -numb;
while (starta <= numa)
{
    if (numa % 2 == 0) {
        Console.Write(starta);
        } else {Console.Write("");
        }
    starta++;
}
Console.Write(" AND ");
while (startb <= numb)
{
    if (numb % 2 == 0) {
    Console.Write(startb);
    } else {Console.Write("");
    }
    startb++;
}
