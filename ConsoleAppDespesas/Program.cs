using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDespesas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp, despesa;
            double valor, total = 0;
            do
            {
                Console.Write("Informe a despesa;");
                despesa = Console.ReadLine();
                Console.Write("Informe o valor:");
                valor = double.Parse(Console.ReadLine());

                total += valor;

                Console.Write("Deseja inserir uma nova despesa? ");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");
            Console.WriteLine("O valor total das despesas é:" + total.ToString("C"));
            Console.Write("Informe o número de pessoas:");
            int pessoas = int.Parse(Console.ReadLine());

            double media = total / pessoas;

            Console.WriteLine("O gasto médio por pessoa é:" + media.ToString("C"));

            Console.ReadKey();
        }
    }
}