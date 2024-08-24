namespace RPG
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public Raca Raca { get; set; }
        public Classe Classe { get; set; }
        public IProfissao Profissao { get; set; }

        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }

        public abstract void Atacar();
        public abstract void Defender();

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Força: {Forca}, Agilidade: {Agilidade}, Inteligência: {Inteligencia}");
        }
    }
}