using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritmeticos 
(
	class Program 
	(

		static void Main(string[] args)
		(
			//Operadores Aritmeticos

			//int num=6; num2=5;
			
			//Console.WriteLine("El resultado de la division es: " + (num % num2) )
			
			//Console.ReadKey()

			double num, pot, resultado;

			Console.WriteLine("Escriba el número que quiere potenciar: ");
			num = Convert.ToDouble(Console.WriteLine());

			Console.WriteLine("Escriba la potencia que quiere elevar: ");
			pot = Convert.ToDouble(Console.WriteLine());

			resultado = Math.Pow(num, pot);

			Console.WriteLine("El resultado es: " + resultado);

			Console.ReadKey();
		)

	)

)