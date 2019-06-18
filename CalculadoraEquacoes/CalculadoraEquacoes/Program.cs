using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEquacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
                bool convercao;
                double a, b, c;

                Console.WriteLine("\t||||||||||||||||||||||||||||||||||||||||\n" +
                                  "\t|| Calculador de Equações Quadráticas ||\n" +
                                  "\t||||||||||||||||||||||||||||||||||||||||\n");

                Console.Write("Entre com o valor de a: ");
                convercao = Double.TryParse(Console.ReadLine(), out a);

                Console.Write("Entre com o valor de b: ");
                convercao = Double.TryParse(Console.ReadLine(), out b);

                Console.Write("Entre com o valor de c: ");
                convercao = Double.TryParse(Console.ReadLine(), out c);

                Console.Write("\n\n");

                Bhaskara1(a, b, c);
                Bhaskara2(a, b, c);
            }

            static void Bhaskara1(double a1, double b1, double c1)
            {
            double delta = Math.Sqrt(Math.Pow(b1, 2) - (4 * a1 * c1));
            string sX1;
            double x1 = (((b1 * (-1)) + delta) / (2 * a1));

            if (delta > 0)
            {
                sX1 = String.Format("x1 é igual a: " + x1);
            }
            else if (delta == 0)
            {
                sX1 = String.Format("Como o valor do descriminante é igual a 0\n\tx é igual a: " + x1);
            }
            else
            {
                sX1 = "A equação não possui raízes reais, pois o descriminante é menor do que 0.";
            }

            Console.WriteLine(sX1 + "\n\n");
        }
        static void Bhaskara2(double a2, double b2, double c2)
        {
            double delta = Math.Sqrt(Math.Pow(b2, 2) - (4 * a2 * c2));

            if (delta > 0)
            {
                double x2 = (((b2 * (-1)) - delta) / 2 * a2);
                Console.WriteLine("x2 é igual a: " + x2 + "\n\n");
            }
        }
        }
    }

