namespace RPG
{
    // Classe Ferreiro que implementa a interface IProfissao
    public class Ferreiro : IProfissao
    {
        public void Trabalhar()
        {
            Console.WriteLine("O ferreiro está forjando uma nova arma.");
        }

        public void Descansar()
        {
            Console.WriteLine("O ferreiro está descansando.");
        }
    }
}