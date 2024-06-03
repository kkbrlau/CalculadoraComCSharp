// See https://aka.ms/new-console-template for more information
using System;
using Calculadora.Models;

Calculadora.Models.Calculadora calc = new Calculadora.Models.Calculadora();

            // Realizando algumas operações e acessando o histórico
            int resultadoSoma = calc.Somar(10, 5);
            Console.WriteLine($"Resultado da soma: {resultadoSoma}");
            
            int resultadoSubtracao = calc.Subtrair(20, 8);
            Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");

            int resultadoMultiplicacao = calc.Multiplicar(6, 4);
            Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");

            int resultadoDivisao = calc.Dividir(100, 10);
            Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");

            // Acessando o histórico
            Console.WriteLine("\nHistórico das últimas operações:");
            foreach (string operacao in calc.Historico())
            {
                Console.WriteLine(operacao);
            }
