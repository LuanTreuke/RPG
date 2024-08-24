namespace RPG
{
    // Classe para a raça Humano que herda de Personagem
    public class Humano : Personagem
    {
        public Humano()
        {
            Forca = 10;
            Agilidade = 10;
            Inteligencia = 10;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} (Humano) ataca com força.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nome} (Humano) defende com estratégia.");
        }
    }
}