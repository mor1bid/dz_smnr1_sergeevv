int[] array = { 4, -3, 7 };

int ind=0, size = array.Length;

while (ind<size) 
{
    if (array[ind] % 2 == 0) 
    {
        Console.Write(array[ind]);
        Console.Write(" - да; ");
    }  
    else 
    {
        Console.Write(array[ind]);
        Console.Write(", ");
    }
    Console.Write("- нет; ");
ind++;
}