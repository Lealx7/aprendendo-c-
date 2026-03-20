class Calculadora
{
    public static double Somar(double a, double b)
    {
        return a + b;
    }

    public static double Subtrari(double a, double b)
    {
        return a - b;
    }

    public static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public static double Dividir(double a, double b)
    {
        if(b == 0)
        {
            Console.WriteLine("Erro: Divisivel por zero");
            return 0;
        }
        return a / b;
    }
}