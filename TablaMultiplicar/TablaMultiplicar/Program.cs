static void CicloInt(int i)
{
    int j = 1;
    while (j <= 12)
    {
        Console.WriteLine(i + " X " + j + " = " + (i * j));
        j++;
    }
    Console.WriteLine(" ");
}
static void CicloExt(int num)
{
    int i = 1;
    while (i <= num)
    {
        CicloInt(i);
        i++;
    }
}

int num = 0;
Console.WriteLine("Digite por favor un número");
num = int.Parse(Console.ReadLine());
CicloExt(num);
