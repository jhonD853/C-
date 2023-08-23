int[,] matriz = new int[5, 5];
int agregar1 = 5;
int agregar2 = 5;
int suma = 0;
int total = 0;
int suma2   = 0;
int total2 = 0;
int a = 0;

for (int fila = 0; fila < agregar1; fila++)
{
    for (int columna = 0; columna < agregar2; columna++)
    {
        Console.WriteLine($"Ingrese el valor para la fila {fila +1}, columna {columna +1} ");
        matriz[fila, columna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("elementos dentro de tu matriz:");

for (int fila = 0; fila < agregar1; fila++)
{
    for (int columna = 0; columna < agregar2; columna++)
    {
        Console.Write(matriz[fila, columna] + "\t");
    }


    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{

    suma = matriz[i, i];
    total = suma + total;
    suma2 += matriz[i, 5 -1 -i];

}
Console.WriteLine($"la suma en diagonal de izquierda a derecha es: {total}");


Console.WriteLine($"la suma en diagonal de derecha a izquierda es: {suma2}");

a=suma2+total;
Console.WriteLine($"la suma de las dos diagonales es: {a}");



