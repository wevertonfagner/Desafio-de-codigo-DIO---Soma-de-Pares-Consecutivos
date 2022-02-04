/* Desafio
O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0. Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

Entrada
O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

Saída
Imprima a saida conforme a explicação acima e o exemplo abaixo. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo_DIO___Soma_de_Pares_Consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());

            while (D != 0)
            {
                // se for impar, some +1
                if (D % 2 != 0)
                {
                    D = D + 1;
                }
                int soma = D + D + 2 + D + 4 + D + 6 + D + 8;
                Console.WriteLine(soma);

                D = int.Parse(Console.ReadLine());
            }
        }
    }
}
