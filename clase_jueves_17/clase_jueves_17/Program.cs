using System;
using System.Collections.Concurrent;

class program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 numero a romano");
            Console.WriteLine("2 romano a numero");
            Console.WriteLine("3 salir");
            Console.WriteLine("escoge puto");
            int option = int.Parse(Console.ReadLine());
            
            if (option == 1) {
                Console.WriteLine("numero");
                int numero = int.Parse(Console.ReadLine());
                string romano = NumeroRomano(numero);
                Console.WriteLine($"el numero es :{romano}");
            }
            else if (option == 2)
            {
                Console.WriteLine("ingrese la letra");
                string romano= Console.ReadLine();
                int numero = romanoNumero(romano);
                Console.WriteLine($"el numero en romano es {romano}, en numero es {numero}");
            }
            else if (option == 3)
            {
                break;
            }
        }
    }
    static string NumeroRomano(int numero)
    {
        string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] Valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string Resultado = "";
        for (int i=0; i<romanos.Length; i++)
        {
            while(numero >= Valores[i])
            {
                Resultado += romanos[i];
                numero -= Valores[i];
            }
        }
        return Resultado;
    }
    static int romanoNumero(string romano)
    {
        Dictionary<char, int> valores = new Dictionary<char, int>
        {
            {'I', 1 }, {'V', 5 }, {'X', 10 }, {'L', 50 }, {'C', 100 },
            {'D', 500 }, {'M', 1000 }
        };
        int numero = 0;
        for (int i=0; i<romano.Length ; i++)
        {
            if (i+1<romano.Length && valores[romano[i]] < valores[romano[i + 1]])
            {
                numero-= valores[romano[i]];
            }
            else
            {
                numero += valores[romano[i]];
            }
        }
        return numero;
    }
}
