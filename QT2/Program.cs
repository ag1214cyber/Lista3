/*-------------------------------------------------------------------
Questão 2: Informações do Personagem
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
    {   int pontos = 0, missao, dificuldade, inimigos, i = 0;
        Console.WriteLine("Numero de missões completadas: ");
        int.TryParse(Console.ReadLine(), out missao);

        while (i < missao)
        {
            Console.WriteLine("teste");
            Console.WriteLine($"Dificuldade (missão {i + 1}):\n1 - Fácil (50 pontos por inimigos)\n2 - Médio (100 pontos por inimigos\n3 - Difícil (150 pontos por inimigo)");
            int.TryParse(Console.ReadLine(), out dificuldade);
            Console.WriteLine($"Inimigos derrotados (missão {i + 1}): ");
            int.TryParse(Console.ReadLine(), out inimigos);

            if (dificuldade == 1)
            {
                pontos = pontos + (inimigos * 50);
            }
            else if (dificuldade == 2)
            {
                pontos = pontos + (inimigos * 100);
            }
            else if (dificuldade == 3)
            {
                pontos = pontos + (inimigos * 150);
            }
            i++;
        }

        Console.WriteLine($"{pontos} Pontos");
        
        Console.WriteLine("\nPressione enter para fechar");
        
        Console.ReadLine();  
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    
    }