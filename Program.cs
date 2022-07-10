int numa = 5, numb = 8;
int starta = 1;
int startb = 1;
while (starta <= numa)
{
    if (numa % 2 == 0) {
        Console.Write(starta);
        } else {Console.Write("");
        numa--;
        }
    starta++;
}
Console.Write(" AND ");
while (startb <= numb)
{
    if (numb % 2 == 0) {
    Console.Write(startb);
        } else {Console.Write("");
        numb--;
        }
    startb++;
}
