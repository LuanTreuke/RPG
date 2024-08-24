using System.Collections.Generic;

namespace RPG
{
    // Classe para gerenciar personagens
    public class GerenciadorDePersonagens
    {
        private List<Personagem> personagens;

        public GerenciadorDePersonagens()
        {
            personagens = new List<Personagem>();
        }

        // Adiciona um novo personagem à lista
        public void AdicionarPersonagem(Personagem personagem)
        {
            personagens.Add(personagem);
        }

        // Retorna a lista de personagens
        public IEnumerable<Personagem> ObterPersonagens()
        {
            return personagens;
        }
    }
}