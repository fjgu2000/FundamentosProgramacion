
int n, ga = 0;
Console.WriteLine("Digite por favor la cantidad de estudiantes");
n = int.Parse(Console.ReadLine());
ga = Ciclo(n);
Console.WriteLine("La cantidad de estudiantes que ganaron es " + ga);

static int Ciclo(int n)
{
    double n1, n2, n3, nf = 0;
    int ga = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite por favor la nota 1");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite por favor la nota 2");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite por favor la nota 3");
        n3 = double.Parse(Console.ReadLine());
        nf = (n1 + n2 + n3) / 3;
        ga += Condicion(nf);
        Console.WriteLine("Su nota defenitiva es " + nf);
    }
    return ga;
}

static int Condicion(double nf)
{
   int ga= 0;
    if (nf > 2.9)
    {
        ga++;
    }
    return ga;
}