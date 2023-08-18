public class Calculadora
{

    public int Suma(int x, int y)
    {
        return x + y;
    }
    public int Resta(int x, int y)
    {
        return x - y;
    }
    public int Multiplicacion(int x, int y)
    {
        return x * y;
    }
   
    public int Division(int x, int y)
    {
        return x / y;
    }
    public int Modulo(int x, int y)
    {
        return x % y;
    }
   
}
class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        int dato = calc.Suma(9,2);
        int dato2 = calc.Resta(8, 9);
        int dato3 = calc.Multiplicacion(9, 9);
        int dato4 = calc.Division(15, 9);
        int dato5 = calc.Modulo(8, 6);
        Console.WriteLine("la respuesta de le suma es");
        Console.WriteLine(dato);
        Console.WriteLine("la respuesta de le resta es");
        Console.WriteLine(dato2);
        Console.WriteLine("la respuesta de le multiplicacion es");
        Console.WriteLine(dato3);
        Console.WriteLine("la respuesta de le division es");
        Console.WriteLine(dato4);
        Console.WriteLine("la respuesta del modulo es");
        Console.WriteLine(dato5);
    }
}
