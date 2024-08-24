namespace RPG.Entities
{
    public class Alquimista : IProfissao
    {
        public void Trabalhar()
        {
            Console.WriteLine("O alquimista está criando uma poção.");
        }

        public void Descansar()
        {
            Console.WriteLine("O alquimista está descansando.");
        }
    }
}