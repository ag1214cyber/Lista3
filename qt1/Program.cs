/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.
@Lista: 03 - Lógica de Programação
@Autor: Arthur Gabriel
@Data: 10/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int totalBau, tiposBau, abrirBau;
        System.Console.WriteLine($"Qual a quantidade total de baus");
        int.TryParse(Console.ReadLine(), out totalBau);
        System.Console.WriteLine($"Quantos tipos de baus");
        int.TryParse(Console.ReadLine(), out tiposBau);
        
        for (int i = 1; i <= tiposBau; i++)
        {
            System.Console.WriteLine($"No {i} tipo, quantos baus vao ser abertos");
            int.TryParse(Console.ReadLine(), out abrirBau);
            while (totalBau - abrirBau < 0)
            {
                System.Console.WriteLine($"Quantidade insuficiente");
                int.TryParse(Console.ReadLine(), out abrirBau);

            }
                totalBau -= abrirBau;
                for (int j = 1; j <= abrirBau; j++)
                {
                    System.Console.WriteLine($"o {j} bau do {i} tipo é: {random.Next(0, 11)}");
                }
        }
            Console.WriteLine("\nClique enter para fechar");
            Console.ReadLine();
       
    }
}