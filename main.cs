/*
Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
*/
using System;

namespace Aritimetica
{
	class Calc
	{
		static void Main(string[] args)
		{
			double	N1, N2, 
        Soma, Subtracao, Multiplicacao, Divisao;
			
			Console.Write("Digite o primeiro número: ");
			N1 = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Digite o segundo número: ");
			N2 = Double.Parse(Console.ReadLine());
			Console.WriteLine();

			Soma = (N1 + N2);
			Subtracao = (N1 - N2);
			Multiplicacao = (N1 * N2);
			Divisao = (N1 / N2);
			
			Console.WriteLine("A soma dos números {0} e {1} é: {2}",N1, N2, Soma);
			Console.WriteLine();
			Console.WriteLine("A subtração dos números {0} e {1} é: {2}",N1, N2, Subtracao);
			Console.WriteLine();
			Console.WriteLine("A multiplicação dos números {0} e {1} é: {2}",N1, N2, Multiplicacao);
			Console.WriteLine();
			Console.WriteLine("A divisão dos números {0} e {1} é: {2}",N1, N2, Divisao);
			Console.WriteLine();
		
		}
	}
}