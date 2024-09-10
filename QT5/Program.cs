/*-------------------------------------------------------------------
Questão 5: Informações do Personagem
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
    static void Main()
    {
        int dias, recompensainicial, incremento, recompensa = 0;
        string? bonus;

        Console.WriteLine("Dias consecutivos: ");
        int.TryParse(Console.ReadLine(), out dias);
        Console.WriteLine("Recompensa inicial: ");
        int.TryParse(Console.ReadLine(), out recompensainicial);
        Console.WriteLine("Incremento diário: ");
        int.TryParse(Console.ReadLine(), out incremento);
        Console.WriteLine("Bônus por marco de dia? (S/N): ");
        bonus = System.Console.ReadLine();
        for (int i = 0; i < dias; i++)
        {
            recompensa = recompensa + recompensainicial + (incremento * i);
        }
        Console.WriteLine($"{recompensa} moedas");
        Console.Write("Pressione ENTER para sair");
        Console.Read();
    }
}
    