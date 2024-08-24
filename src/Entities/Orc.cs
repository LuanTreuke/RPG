namespace RPG
{
    // Classe para a raça Orc que herda de Personagem
    public class Orc : Personagem
    {
        public Orc()
        {
            Forca = 16;
            Agilidade = 6;
            Inteligencia = 6;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} (Orc) ataca com brutalidade.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nome} (Orc) defende com força bruta.");
        }
    }
}