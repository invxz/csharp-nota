namespace desafiomaneirao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota = 0.00;

            Console.WriteLine("Digite seu name INTENSO: ");
            nome = Console.ReadLine();

            Console.WriteLine("digite sua notaaa:");
            nota = double.Parse(Console.ReadLine());

            if (nota <= 5.9)
            {
                Console.WriteLine("Oi " + nome + " você esta de recuperação.");
            }

            else if(nota >=6)
            {
                Console.WriteLine("Oi " + nome + " você passou!");
            }

        }
    }
}