using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> lista = new Dictionary<string, string>();
        int contador = 1;

        Console.WriteLine("Ingresa los datos que desea almacenar o escribe 0 para finalizar.");

        while (true)
        {
            Console.Write($"Ingrese la clave nummero {contador} o escriba 0 para finalizar: ");
            string dato = Console.ReadLine();
            if (dato == "0")
                break;
            Console.WriteLine($"ingrese valor de la clave {dato}");
            string dato01 = Console.ReadLine();
            

            

            lista.Add(dato, dato01);
            contador++;
        }

        Console.WriteLine("\nDatos ingresados:");

        foreach (var item in lista)
        {
            Console.WriteLine($"la clave es" +
                $": {item.Key} y su valor es: {item.Value}");
        }
    }
}