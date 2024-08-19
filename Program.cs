using System;
using System.Globalization;
namespace Exercicio9_2
{
    class Program
    {
        static void Main (string[] args)
        {
            /*Crie uma calculadora simples que permita ao usuário realizar as quatro operações básicas (adição, subtração, multiplicação e divisão).*/
            /*
                *O que você pode fazer para melhorar e demonstrar mais seu potencial?*

                1. *Adicionar funcionalidades mais avançadas:*
                    * *Operações trigonométricas:* seno, cosseno, tangente, etc.
                    * *Funções exponenciais e logarítmicas:* potência, raiz, logaritmo natural, etc.
                    * *Constantes matemáticas:* pi, euler, etc.
                    * *Conversão de unidades:* metros para pés, Celsius para Fahrenheit, etc.
                    * *Cálculos financeiros:* juros compostos, valor presente, etc.
                    * *Funções estatísticas:* desvio padrão, variância, etc.
                
                2. *Implementar uma interface gráfica:*
                    * Utilizar Windows Forms ou WPF para criar uma interface mais intuitiva e profissional.
                    * Adicionar botões, caixas de texto e outros elementos visuais para interagir com o usuário.
                
                3. *Melhorar o tratamento de erros:*
                    * Verificar se a entrada do usuário é válida (números, operações).
                    * Tratar divisões por zero.
                    * Exibir mensagens de erro claras e informativas.
                
                4. *Utilizar estruturas de dados:*
                    * Utilizar arrays ou listas para armazenar um histórico de cálculos.
                    * Implementar uma pilha para realizar cálculos mais complexos.
                
                5. *Implementar algoritmos mais complexos:*
                    * Utilizar algoritmos de ordenação ou busca para realizar cálculos mais avançados.
                    * Implementar funções recursivas para resolver problemas de forma mais elegante.
                
                6. *Utilizar conceitos de programação orientada a objetos:*
                    * Criar classes para representar diferentes tipos de cálculos (aritméticos, trigonométricos, etc.).
                    * Utilizar herança e polimorfismo para criar uma hierarquia de classes.
 
            */

            Calculadora calc = new Calculadora ();

            Console.WriteLine ("Aqui estão os tipos de calculadoras, entre com alguma delas: ");
            Console.WriteLine ("1 - Básica");
            Console.WriteLine ("2 - Trigonométricas");
            Console.WriteLine ("3 - Raíz quadrada");
            Console.WriteLine ();
            string calcDesejada = Console.ReadLine ();

            if (calcDesejada == "1")
            {

                Console.WriteLine ("Entre com o primeiro número: ");
                calc.Num1 = double.Parse (Console.ReadLine ());
                Console.WriteLine ("Entre com o segundo número: ");
                calc.Num2 = double.Parse (Console.ReadLine ());

                Console.WriteLine ();

                Console.WriteLine ("Aqui está uma lista de operadores para ser realizado com os números de entrada: ");

                Console.WriteLine ("1 - adição(+)");
                Console.WriteLine ("2 - subtração(-)");
                Console.WriteLine ("3 - multiplicação(x ou *)");
                Console.WriteLine ("4 - divisão(/)");
                Console.WriteLine ("5 - média");

                Console.WriteLine ("Entre com algum desses operadores: ");

                string operacaoDesejada = Console.ReadLine ();

                Console.WriteLine ();

                if (operacaoDesejada == "1")
                {
                    Console.WriteLine (calc.soma ());
                }
                else if (operacaoDesejada == "2")
                {
                    Console.WriteLine (calc.subtracao ());
                }
                else if (operacaoDesejada == "3")
                {
                    Console.WriteLine (calc.multiplicacao ());
                }
                else if (operacaoDesejada == "4")
                {
                    Console.WriteLine (calc.divisao ());
                }
                else if (operacaoDesejada == "5")
                {
                    Console.WriteLine (calc.media ());
                }

            }
            else if (calcDesejada == "2")
            {
                Console.Write ("Digite o ângulo do triângulo retangulo: ");
                calc.Angulo = double.Parse (Console.ReadLine ());

                double anguloRadianos = calc.Angulo * Math.PI / 180;

                Console.WriteLine (anguloRadianos);
                double seno = Math.Sin (anguloRadianos);
                double cosseno = Math.Cos (anguloRadianos);
                double tangente = Math.Tan (anguloRadianos);

                Console.WriteLine ($"Seno: {seno:F4}");
                Console.WriteLine ($"Cosseno: {cosseno:F4}");
                Console.WriteLine ($"Tangente: {tangente:F4}");
            }
            else if (calcDesejada == "3")
            {
                Console.WriteLine ("Digite o número para saber a raíz dele: ");
                calc.raiz = double.Parse (Console.ReadLine ());
                Console.WriteLine ("Deseja saber a raíz quadrada, cúbica ou quarta?");
                string calculaRaizTipo = Console.ReadLine ();
                if (calculaRaizTipo == "quadrada")
                {
                    Console.WriteLine ($"A raíz quadrada de {calc.raiz} é " + calc.calculaRaizQuadrada ());
                }
                else if (calculaRaizTipo == "cúbica")
                {
                    Console.WriteLine ($"A raíz cúbica de {calc.raiz} é " + calc.calculaRaizCubica ());
                }
                else
                {
                    Console.WriteLine ($"A raíz quarta de {calc.raiz} é " + calc.calculaRaizQuarta ());
                }
            }



            Console.WriteLine ();
            Console.WriteLine ("Entre com qualquer tecla para sair");
            Console.ReadLine ();
        }
    }
}