using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDePersonagens gerenciador = new GerenciadorDePersonagens();

            // Criação de personagens
            Personagem heroi = gerenciador.CriarPersonagem("Aragorn", Raca.Humano, Classe.Guerreiro, new Ferreiro());
            Personagem inimigo = gerenciador.CriarPersonagem("Azog", Raca.Orc, Classe.Guerreiro, new Mercador());

            // Exibe os detalhes dos personagens
            heroi.ExibirDetalhes();
            inimigo.ExibirDetalhes();
            
            // Inicia o combate
            gerenciador.Combate(heroi, inimigo);
        }
    }
}
