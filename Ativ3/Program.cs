using System;

namespace Ativ3
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            int salario;
            Console.WriteLine("Informe seu salário:");
            salario = Convert.ToInt16(Console.ReadLine());

            if (salario <= 1100)
            {
                double v = 0.075 * salario;
                double g = salario - v;
                Console.WriteLine($"Seu salario descontado do INSS é {g} reais");
            }

            else if (salario >= 1100.01 & salario <= 2003.48)
            {
                double h = 0.09 * salario;
                double i = salario - h;
                Console.WriteLine($"Seu salario descontado do INSS é {i} reais");
            }

            else if (salario >= 2003.49 & salario <= 3305.22)
            {
                double j = 0.12 * salario;
                double m = salario - j;
                Console.WriteLine($"Seu salario descontado do INSS é {m} reais");
            }

            else if (salario >= 3305.23 & salario <= 6433.57)
            {
                double d = 0.14 * salario;
                double a = salario - d;
                Console.WriteLine($"Seu salario descontadoo do INSS é {a} reais");
            }
        }
    }



}
