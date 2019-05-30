using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira_Renda_Fixa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis para a aplicação.
            double valorInvestido = 0;
            int mesesPeriodo = 0;
            double resultadoPoupanca = 0;
            string mesPlural = string.Empty;
            double resultadoRendaFixa = 0;

            //Usuário informa o valor a ser aplicado.
            Console.Write("Quanto deseja investir por Mês: ");
            valorInvestido = double.Parse(Console.ReadLine());

            //Usuário informa a quantidade de meses que vai aplicar.
            Console.Write("Quantos meses pretende investir: ");
            mesesPeriodo = int.Parse(Console.ReadLine());

            //Resultado já dando o valor total do que investil e do que será investido
            resultadoPoupanca = (valorInvestido * mesesPeriodo) * 0.0066;
            resultadoRendaFixa = (valorInvestido * mesesPeriodo) * 0.0098;

            if (mesesPeriodo == 1)
            {
                mesPlural = "mês";
            }

            else
            {
                mesPlural = "meses";
            }

            //Usuário receber a mensagem com o valor total do rendimento no final do período desejado.
            Console.WriteLine("O Valor total do redimento da Poupança será de: {0} no período de: {1} {2}", resultadoPoupanca, mesesPeriodo, mesPlural);
            Console.WriteLine("O Valor total do redimento da Renda Fixa será de: {0} no período de: {1} {2}", resultadoRendaFixa, mesesPeriodo, mesPlural);
            Console.Write("O rendimento mais vantajoso é o Renda Fixa.");
            Console.ReadKey();
        }
    }
}
