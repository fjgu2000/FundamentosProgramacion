static void Mariajo(string[] nomb, double[] salario, int n)
{
    int x = 0;
    double aux;
    string auxno;
    do 
    {
        int y = 0;
        while(y < (n-1))
        {
            if (salario[y]< salario[y+1])
            {
                aux = salario[y];
                auxno = nomb[y];
                salario[y] = salario[y + 1];
                nomb[y] = nomb[y + 1];
                salario[y + 1]= aux;
                nomb[y+1] = auxno;
            }
            y++;
        }
        x++; 
    } while (x < (n - 1));

    Alumnos(nomb, salario, n);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite por favor la cantidad de empleados");
int n=int.Parse(Console.ReadLine());
Console.WriteLine("Digite por favor el salario base de los empleados");
int sal = int.Parse(Console.ReadLine());
Javier(n,sal);

static void Javier(int n, int sal )
{
    string[] nomb = new string[n];
    double[] salario = new double[n];
    int nven;
    double total = 0, comi = 0;
    for(int i = 0; i < n; i++)
    {
        total = 0;
        Console.WriteLine("Digite por favor el número de ventas");
        nven = int.Parse(Console.ReadLine());
        comi = Santiago(nven);
        total += (sal + comi);
        Console.WriteLine("Digite por favor el nombre del empleado " + (i + 1));
        string nom=Console.ReadLine();
        nomb[i] = nom;
        salario[i] = total;
    }
    Mariajo(nomb, salario, n);
}
static double Santiago(int nven)
{
    double comi = 0, ventas = 0;
    int j = 0, com;
    while(j < nven)
    {
        Console.WriteLine("Digite por favor el valor del artículo " + (j + 1));
        com = int.Parse(Console.ReadLine());
        ventas += com;
        j++;
    }
    comi = Felipe(nven, ventas);
    return comi;
}
static double Felipe(int nven, double ventas)
{
    double comi = 0;
    if( nven < 6 )
    {
        comi = ventas * 0.05;
    }
    else if (nven < 11)
    {
        comi = ventas * 0.09;
    }
    else
    {
        comi = ventas * 0.12;
    }
    return comi;
}

static void Alumnos(string[] nomb, double[] salario, int n)
{
    int i = 0;
    do
    {
        Console.WriteLine(nomb[i] + " Su salario es $" + salario[i]);
        i++; 
    } while(i < nomb.Length);
}