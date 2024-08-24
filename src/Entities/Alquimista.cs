namespace RPG
{
    public class Alquimista : IProfissao
    {
        // Classe Alquimista que implementa a interface IProfissao
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