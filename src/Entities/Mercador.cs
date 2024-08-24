namespace RPG.Entities
{
    public class Mercador : IProfissao
    {
        public void Trabalhar()
        {
            Console.WriteLine("O mercador está negociando mercadorias.");
        }

        public void Descansar()
        {
            Console.WriteLine("O mercador está descansando.");
        }
    }
}