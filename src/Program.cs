using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDePersonagens gerenciador = new GerenciadorDePersonagens();

            Personagem heroi = gerenciador.CriarPersonagem("Aragorn", Raca.Humano, Classe.Guerreiro, new Ferreiro());
            Personagem inimigo = gerenciador.CriarPersonagem("Azog", Raca.Orc, Classe.Guerreiro, new Mercador());

            heroi.ExibirDetalhes();
            inimigo.ExibirDetalhes();

            gerenciador.Combate(heroi, inimigo);
        }
    }
}
