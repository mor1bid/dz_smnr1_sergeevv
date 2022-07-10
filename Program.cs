int [] array = { 4, -3, 7 };
int ind=0, size = array.Length;
while (ind<size) {
if (array[ind] % 2) {
Console.Write(array[ind]);
} else
ind++;
}