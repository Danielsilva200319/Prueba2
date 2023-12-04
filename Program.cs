internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("      Multiplicación Rusa".ToUpper());
        Console.Write("Ingrese el número multiplicador: ");
        int multiplicador = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el número multiplicando: ");
        int multiplicando = Convert.ToInt32(Console.ReadLine());
        int pares = multiplicador % 2;
        
        /* int resultado;
        resultado = 12;
        Console.WriteLine($"{resultado}");
        Console.WriteLine($" {multiplicador}, {multiplicando}"); */
    }
}