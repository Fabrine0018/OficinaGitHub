using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Digite outro número: ");
        double num2= Convert.ToDouble(Console.ReadLine());

        double resultado = num * num2;
        Console.WriteLine(" O resultado da multiplicação é " +  resultado);
        
        Console.ReadKey();
    }
}
