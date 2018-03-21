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
			// kk eaw man
			Console.WriteLine("Entre com o codigo: ");
			Console.WriteLine("Codigo 1 - Tirar 10% de um valor: ");
			Console.WriteLine("Codigo 2 - Tirar x% de um valor: ");
			Console.WriteLine("Codigo 3 - Dizer se o numero e par ou impar: ");
			Console.WriteLine("Codigo 4 - Resolver uma função de 1º grau: ");
			Console.WriteLine("Codigo 5 - Resolver uma função de 2º grau: ");
			int cod = Convert.ToInt32(Console.ReadLine());

			if (cod == 1)
			{
				Console.WriteLine("Entre com o valor q deseja tirar 10%: ");

				double valor1 = Convert.ToDouble(Console.ReadLine());
				double resp = valor1 * 0.1 ;

				Console.WriteLine("10% do valor " + valor1 + " é: " + resp);
				Console.ReadKey();


			}
			if (cod == 2)
			{
				Console.WriteLine("Entre com o numero: ");
				double valor1 = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Entre com a %: ");
				double por = Convert.ToDouble(Console.ReadLine());

				double resp = (valor1 * por) / 100;

				Console.WriteLine("A porcentagem de " + por + "% do valor " + valor1 + " é: " + resp);
				Console.ReadKey();

			}

			if (cod == 3)
			{
				Console.WriteLine("Digite um Número: ");



			}

			if (cod == 4)
			{


			}
			else
			{


			}
		}
	}
}