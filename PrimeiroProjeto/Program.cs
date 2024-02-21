namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Maria Vitória";
            int idade = 16;
            string cidade = "Campos do Jordão";

            Console.WriteLine("qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("qual é a sua idade?");
            idade = int.Parse (Console.ReadLine());

            Console.WriteLine("qual é a saus cidade?");
            cidade = Console.ReadLine();

            Console.WriteLine("NOME - {0} \n IDADE - {1} \n CIDADE - {2}", nome, idade, cidade);

        }
    }
}