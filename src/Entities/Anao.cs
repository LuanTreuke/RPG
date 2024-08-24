namespace RPGConsole
{
    public class Anao : Personagem
    {
        public Anao()
        {
            Forca = 14;
            Agilidade = 8;
            Inteligencia = 8;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} (Anão) ataca com grande força.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nome} (Anão) defende com resistência.");
        }
    }
}
