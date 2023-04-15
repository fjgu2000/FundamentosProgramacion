int x, y, com, bal;
double total = 0, gtotal = 0, pago = 0;
Console.WriteLine("Digite por favor la cantidad de usuarios");
x = int.Parse(Console.ReadLine());
gtotal = Javier(x);
Console.WriteLine("El valor de las ventas fue $"+gtotal);

static double Javier(int x)
{
    int y;
    double gtotal = 0, total = 0;
    for(int i = 0; i < x; i++)
    {
        Console.WriteLine("Digite por favor la cantidad de artículos del usuario " + (i + 1));
        y = int.Parse(Console.ReadLine());
        total = Felipe(y);
        Console.WriteLine("El valor a pagar es $" + total);
        gtotal += total;
    }
    return gtotal;
}
static double Felipe(int y)
{
    int j = 0, com, bal;
    double pago = 0, total = 0;
    while (j < y)
    {
        Console.WriteLine("Digite por favor el precio del producto " + (j + 1));
        com = int.Parse(Console.ReadLine());
        pago += com;
        j++;
    }
    Console.WriteLine("Digite por favor el # de la Balota");
    bal = int.Parse(Console.ReadLine());
    total = Mariajo(bal, pago);
    return total;
}

static double Mariajo(int bal, double pago)
{
    double total = 0;
    if (bal == 1)
    {
        total = pago * 0.93;
    }
    else if (bal == 2)
    {
        total = pago * 0.85;
    }
    else if (bal == 3)
    {
        total = pago * 0.75;
    }
    else if (bal == 4)
    {
        total = pago * 0.7;
    }
    else if (bal == 5)
    {
        total = pago * 0.55;
    }
    else
    {
        total = pago;
    }
    return total;
}