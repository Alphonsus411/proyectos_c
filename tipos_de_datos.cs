using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_datos
{
	class Program
	{
		static void Main(string[] args)
		{
			// valores de byte desde 0 a 255
			//byte variable = 230;

			// Enteros
			//int variable = -2147483647;

			//Flotante
			//double variable = 56.78;

			//Booleano
			//bool variable = True;

			//Character
			//char variable = 'C';

			//String
			//string variable = "Esto es una cadena";

			//Dynamic(cuando no sabemos el tipo de variable)
			dynamic variable = 23;
			

			Console.WriteLine("El valor de la variable es " + variable);

			Console.ReadKey()
			/*Usamos el parámetro de escritura en pantalla y lo 
			llamamos con ReadKey*/


		}
	}
}