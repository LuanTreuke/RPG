using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o gerenciador de personagens
            GerenciadorDePersonagens gerenciador = new GerenciadorDePersonagens();

            // Menu de interação com o usuário
            Menu(gerenciador);
        }

        static void Menu(GerenciadorDePersonagens gerenciador)
        {
            while (true)
            {
                Console.WriteLine("Menu RPG");
                Console.WriteLine("1. Criar Personagem 1");
                Console.WriteLine("2. Criar Personagem 2");
                Console.WriteLine("3. Mostrar Personagens");
                Console.WriteLine("4. Lutar entre Personagens");
                Console.WriteLine("5. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        CriarPersonagem(gerenciador, 1);
                        break;
                    case 2:
                        CriarPersonagem(gerenciador, 2);
                        break;
                    case 3:
                        MostrarPersonagens(gerenciador);
                        break;
                    case 4:
                        LutarEntrePersonagens(gerenciador);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CriarPersonagem(GerenciadorDePersonagens gerenciador, int numero)
        {
            Console.WriteLine($"Criar Personagem {numero}");

            // Entrada de dados do usuário
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Raça (Humano, Elfo, Anão, Orc): ");
            Raca raca = (Raca)Enum.Parse(typeof(Raca), Console.ReadLine(), true);

            Console.Write("Classe (Guerreiro, Mago, Arqueiro): ");
            Classe classe = (Classe)Enum.Parse(typeof(Classe), Console.ReadLine(), true);

            Console.Write("Profissão (Ferreiro, Alquimista, Mercador): ");
            IProfissao profissao = CriarProfissao(Console.ReadLine());

            // Criação do personagem baseado na raça
            Personagem personagem = CriarPersonagemPorRaca(nome, raca);
            personagem.Classe = classe;
            personagem.Profissao = profissao;

            // Adiciona o personagem ao gerenciador
            gerenciador.AdicionarPersonagem(personagem);

            Console.WriteLine($"Personagem {numero} criado com sucesso!");
        }

        static Personagem CriarPersonagemPorRaca(string nome, Raca raca)
        {
            Personagem personagem = raca switch
            {
                Raca.Humano => new Humano { Nome = nome },
                Raca.Elfo => new Elfo { Nome = nome },
                Raca.Anao => new Anao { Nome = nome },
                Raca.Orc => new Orc { Nome = nome },
                _ => throw new ArgumentException("Raça inválida")
            };
            return personagem;
        }

        static IProfissao CriarProfissao(string profissao)
        {
            return profissao.ToLower() switch
            {
                "ferreiro" => new Ferreiro(),
                "alquimista" => new Alquimista(),
                "mercador" => new Mercador(),
                _ => throw new ArgumentException("Profissão inválida")
            };
        }

        static void MostrarPersonagens(GerenciadorDePersonagens gerenciador)
        {
            Console.WriteLine("Personagens:");

            foreach (var personagem in gerenciador.ObterPersonagens())
            {
                personagem.ExibirDetalhes();
            }
        }

        static void LutarEntrePersonagens(GerenciadorDePersonagens gerenciador)
        {
            var personagens = gerenciador.ObterPersonagens().ToList();

            if (personagens.Count < 2)
            {
                Console.WriteLine("Não há personagens suficientes para lutar.");
                return;
            }

            Console.WriteLine("Escolha o primeiro personagem (1 ou 2): ");
            int primeiro = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Escolha o segundo personagem (1 ou 2): ");
            int segundo = int.Parse(Console.ReadLine()) - 1;

            if (primeiro >= personagens.Count || segundo >= personagens.Count || primeiro == segundo)
            {
                Console.WriteLine("Escolhas inválidas.");
                return;
            }

            Personagem p1 = personagens[primeiro];
            Personagem p2 = personagens[segundo];

            // Simulação de combate simples
            Console.WriteLine($"{p1.Nome} ataca {p2.Nome}!");
            // Aqui você pode adicionar a lógica de combate real

            Console.WriteLine($"{p2.Nome} ataca de volta!");
            // Lógica de combate real
        }
    }
}