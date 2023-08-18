Random random = new Random();
int aleatorio= random.Next(1, 51);
int num1=0;
int acumulador=0;

Console.WriteLine("adivine que numero escogio la computadora del 1 al 50");

while (aleatorio != num1)
{
    
    Console.WriteLine($"por favor digite el numero que cree que escojio la consola");
    num1=int.Parse( Console.ReadLine() );
    acumulador++;

    if (num1 < aleatorio)
    {
        Console.WriteLine("el numero esta por debajo del seleccionado por la consola");

    }else if (num1 > aleatorio)
    {
        Console.WriteLine("el numero es mayor al seleccionado por la consola");
    }

    if (aleatorio==num1)
    {
        Console.WriteLine($"felicidades adivino el numero con {acumulador} intentos");
    }
    else
    {
        Console.WriteLine($"lleva {acumulador} intentos");
    }
}
