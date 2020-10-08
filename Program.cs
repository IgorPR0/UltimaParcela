using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ultima Parcela//
            double valorInt , Parcelas , Conta;

            DateTime Data = DateTime.Now;
            DateTime ValorPar;

            //Valor Total da Conta//
            Console.Write("Valor = ");
            valorInt = Convert.ToDouble(Console.ReadLine());

            //Quantas Parcelas?//
            Console.Write("Quantidade de Parcelas = ");
            Parcelas = Convert.ToDouble(Console.ReadLine());

            //Divisão de Valor//
            Conta = valorInt / Parcelas;

            ValorPar = Data.AddMonths(8);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nSucesso ultima parcela disponivel em: {ValorPar}, no valor de R${Conta}");
            Console.ResetColor();
        }
    }
}