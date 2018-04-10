using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
        static void Main(string[] args)
		{ 
			//Entrada do codigo para a função.
			Console.WriteLine("Entre com o codigo: ");
			Console.WriteLine("Codigo 1 - Tirar 10% de um valor: ");
			Console.WriteLine("Codigo 2 - Tirar x% de um valor: ");
			Console.WriteLine("Codigo 3 - Dizer se o numero e par ou impar: ");
			Console.WriteLine("Codigo 4 - Resolver uma função de 1º grau: ");
			Console.WriteLine("Codigo 5 - Resolver uma função de 2º grau: ");
            Console.WriteLine("Codigo 6 - Fatorial de um numero: ");
            Console.WriteLine("Codigo 7 - Fibonnaci de um numero: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            //Condicional para a escolha do codigo.
			if (cod == 1)
			{  
                //O usuario entra com o valor da primeira função.
				Console.WriteLine("Entre com o valor q deseja tirar 10%: ");
                double valor1 = Convert.ToDouble(Console.ReadLine());

                //Calculo da porcentagem.
                double resp = valor1 * 0.1 ;

				Console.WriteLine("10% do valor " + valor1 + " é: " + resp);
				Console.ReadKey();


			}
			if (cod == 2)
            {
                //O usuario entra com o valor para tirar a %.
                Console.WriteLine("Entre com o numero: ");
				double valor1 = Convert.ToDouble(Console.ReadLine());

                //O usuario entra com a % que ele deseja.
                Console.WriteLine("Entre com a %: ");
				double por = Convert.ToDouble(Console.ReadLine());

                //Calculo da %.
				double resp = (valor1 * por) / 100;

				Console.WriteLine("A porcentagem de " + por + "% do valor " + valor1 + " é: " + resp);
				Console.ReadKey();

			}

			if (cod == 3)
			{
                //O usuario entra com o numero para dizer se e par ou impar.
                Console.WriteLine("Digite um Número: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());

                //Calculo para ver se retorna 0 ou 1.
                int resp = valor1 % 2;

                //O que o programa ira mostrar dependendo do calculo.
                if (resp == 0)
                {
                    Console.WriteLine("O numero e par.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("O numero e impar.");
                    Console.ReadKey();

                }


            }

			if (cod == 4)
			{
                //O usuario ira entrar com os valores a e b.
                Console.WriteLine("Entre com o valor de a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entre com o valor de b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                //Calculo da função de 1º grau.
                double resp = -(b / a);

                Console.WriteLine("O valor da equação de 1º grau e: " + resp);
                Console.ReadKey();

            }

            if (cod == 5)
            {
                //O usuario ira entrar com os valores a, b e c.
                Console.WriteLine("Entre com o valor de a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entre com o valor de b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entre com o valor de c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                //Calculo do Delta da função.
                double raiz = (Math.Pow(b, 2) - (4 * a * c));

                //Calculo do X1 e X2.
                double valor1 = (-b + Math.Sqrt(raiz)) / (2 * a);
                double valor2 = (-b - Math.Sqrt(raiz)) / (2 * a);

                Console.WriteLine("O valor de x1: " + valor1);
                Console.WriteLine("O valor de x2: " + valor2);
                Console.ReadKey();


            }

            if (cod == 6)
            {
                //O usuario ira entrar com o valor q deseja tirar o fatorial.
                Console.WriteLine("Entre com o numero que você deseja tirar o fatorial: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());

                //variavel para somar o fatorial.
                int num = 1;

                //Loop ate o valor desejado.
                for (int i=1; i<= valor1; i++)
                {

                    num = num * i;

                 }

                Console.WriteLine("A fatorial de " + valor1 + "! é: " + num);
                Console.ReadKey();

            }
            if (cod == 7)
            {
                //O usuario ira entrar com o que deseja saber do fibonnaci.
                Console.WriteLine("Entre com o numero que você deseja do Fibonnaci: ");
                int n = Convert.ToInt32(Console.ReadLine());

                //Variaveis para calcular o fibonnaci.
                int a = 0;
                int b = 1;

                //Loop para somar ate o valor desejado.
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                }

                Console.WriteLine("O Fibonnaci do numero " + n + " é: " + a);
                Console.ReadKey();

            }
            
           
		}
	}
}