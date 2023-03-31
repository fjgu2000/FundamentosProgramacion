int n = 0, total = 0;
Console.WriteLine("Digite por favor un número");
n = int.Parse(Console.ReadLine());
total=CicloExt(n);
Console.WriteLine("La suma de los números factoriales es "+total);

static int CicloExt(int n)
{
    int total = 0, fac = 0, num;
    for(int i=1;i <= n;i++)
    {
        Console.WriteLine("Digite un número por favor");
        num = int.Parse(Console.ReadLine());
        fac = CicloInt(num);
        Console.WriteLine("El valor factorial de " + num + " es " + fac);
        total += fac;
    }
    return total;
}

static int CicloInt(int num)
{
    int fac = 1;
    for(int j=2;j <= num;j++)
    {
        fac *= j;
    }
    return fac;
}