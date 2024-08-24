namespace RPG
{
    // Classe para a raça Elfo que herda de Personagem
    public class Elfo : Personagem
    {
        public Elfo()
        {
            Forca = 8;
            Agilidade = 12;
            Inteligencia = 14;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} (Elfo) ataca com precisão.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nome} (Elfo) defende com agilidade.");
        }
    }
}