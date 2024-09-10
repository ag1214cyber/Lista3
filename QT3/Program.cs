/*-------------------------------------------------------------------
Questão 3: Informações do Personagem
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
         int tipos, quantidade = 0, capacidade, total = 0;
        Console.WriteLine("Tipos de item: ");
        int.TryParse(Console.ReadLine(), out tipos);

        for (int i = 0; i < tipos; i++)
        {
            Console.WriteLine($"Nome do item {i + 1}:");
            Console.ReadLine();
            Console.WriteLine("Quantidade do item no inventário: ");
            int.TryParse(Console.ReadLine(), out quantidade);
            total += quantidade;
        }
        Console.WriteLine("Capacidade máxima: ");
        int.TryParse(Console.ReadLine(), out capacidade);

        if (total > capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Excede a capacidade.");
        }
        else if (total < capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Dentro da capacidade.");
        }
        else if (total == capacidade)
        {
            System.Console.WriteLine($"Total: {total} itens. Dentro da capacidade");
    } 
    }
}