using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInt , Parcelas , Conta;

            DateTime Data = DateTime.Now;
            DateTime ValorPar;

            Console.Write("Valor inteiro= ");
            valorInt = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de Parcelas= ");
            Parcelas = Convert.ToDouble(Console.ReadLine());

            Conta = valorInt / Parcelas;

            ValorPar = Data.AddMonths(8);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nSucesso ultima parcela disponivel em: {ValorPar}, no valor de R${Conta}");
            Console.ResetColor();
        }
    }
}