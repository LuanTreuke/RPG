namespace RPG
{


    public class GerenciadorDePersonagens
    {
        public Personagem CriarPersonagem(string nome, Raca raca, Classe classe, IProfissao profissao)
        {
            Personagem personagem;

            switch (raca)
            {
                case Raca.Humano:
                    personagem = new Humano();
                    break;
                case Raca.Elfo:
                    personagem = new Elfo();
                    break;
                case Raca.Anao:
                    personagem = new Anao();
                    break;
                case Raca.Orc:
                    personagem = new Orc();
                    break;
                default:
                    throw new ArgumentException("Raça inválida.");
            }

            personagem.Nome = nome;
            personagem.Raca = raca;
            personagem.Classe = classe;
            personagem.Profissao = profissao;

            return personagem;
        }

        public void Combate(Personagem p1, Personagem p2)
        {
            Console.WriteLine($"{p1.Nome} está lutando contra {p2.Nome}!");

            p1.Atacar();
            p2.Defender();

            p2.Atacar();
            p1.Defender();

            if (p1.Forca > p2.Forca)
            {
                Console.WriteLine($"{p1.Nome} venceu a batalha!");
            }
            else if (p2.Forca > p1.Forca)
            {
                Console.WriteLine($"{p2.Nome} venceu a batalha!");
            }
            else
            {
                Console.WriteLine("A batalha terminou em empate!");
            }
        }
    }
}