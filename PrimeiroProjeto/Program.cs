namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Maria Vitória";
            int idade = 16;
            string cidade = "Campos do Jordão";
            int n1 ,n2;
            int soma;
            int subt;
            int div;
            int mult;

            Console.WriteLine("qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("qual é a sua idade?");
            idade = int.Parse (Console.ReadLine());

            Console.WriteLine("qual é a sua cidade?");
            cidade = Console.ReadLine();

            Console.WriteLine("NOME - {0} \n IDADE - {1} \n CIDADE - {2}", nome, idade, cidade);

            Console.WriteLine("Agora, vamos fazer uma calculadora");

            Console.WriteLine("escolha um valor para n1");
            n1 = int.Parse (Console.ReadLine());

            Console.WriteLine("escolha um valor para n2");
            n2 = int.Parse (Console.ReadLine());

            soma = n1 + n2;
            subt = n1 - n2;
            div = n1 / n2;
            mult = n1 * n2;

            Console.WriteLine("os resultados são: \n SOMA - {0} \n SUBTRAÇÃO - {1} \n MULTIPLICAÇÃO - {2} \n DIVISÃO - {3} ",soma, subt,mult,div);
        }
    }
}