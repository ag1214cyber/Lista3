/*-------------------------------------------------------------------
Questão 4: Informações do Personagem
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
       double pontos, fases, i = 0, cura = 0;
        string? item;
        Console.WriteLine("Número de fases: ");
        double.TryParse(Console.ReadLine(), out fases);
        System.Console.WriteLine("Pontos por fase: ");
        double.TryParse(Console.ReadLine(), out pontos);
        while (i < fases)
        {

            Console.WriteLine($"Usou itens de cura? ({i + 1}ª fase): ");
            item = Console.ReadLine();

            if (item == "S" || item == "s")
            {
                System.Console.WriteLine("Quantos pontos de cura?");
                double.TryParse(Console.ReadLine(), out cura);
                cura = cura + cura;
            }
            if (item == "N" || item == "n")
            {
                cura = cura + 0;
            }
            i++;
        }  
    } 
    }

