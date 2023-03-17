using ExsAbstracaoProfGustavo;

internal class Program
{
    private static void Main(string[] args)
    {
        string name, goals;
        int age, ex;
        double balance, value;

        //Console.WriteLine("EXERCÍCIO: \n (1) \n (2) \n (3) \n (4) - Sair");
        //Console.Write("Escolha um exercício para executar: ");
        //ex = int.Parse(Console.ReadLine());
        //Console.Clear();

        do
        {
            Console.Clear();
            Console.WriteLine("EXERCÍCIO: \n (1) \n (2) \n (3) \n (4) - Sair");
            Console.Write("Escolha um exercício para executar: ");
            ex = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (ex)
            {
                case 1:
                    Console.WriteLine("------EXERCÍCIO 1 - ABSTRAÇÃO--------");
                    Console.WriteLine("\n    Realizando sua apresentação       ");
                    Console.WriteLine("--------------------------------------\n\n");
                    Console.Write("Informe seu nome: ");
                    name = Console.ReadLine();
                    Console.Write("Informe sua idade: ");
                    age = int.Parse(Console.ReadLine());
                    Console.Write("Qual o seu objetivo? ");
                    goals = Console.ReadLine();

                    Console.WriteLine($"\nOlá meu nome é {name}, tenho {age} anos e meu objetivo é {goals}");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("------EXERCÍCIO 2 - ABSTRAÇÃO--------");
                    Console.WriteLine("\n    Saques, depósitos e balanço       ");
                    Console.WriteLine("--------------------------------------\n\n");
                    balance = 100.00;
                    Console.WriteLine("Seu saldo é de R$" + balance +",00");
                    Saque(10);
                    Saque(50);
                    Deposito(100);
                    Console.ReadKey();

                    break;

                case 3:
                    Console.WriteLine("------EXERCÍCIO 3 - ABSTRAÇÃO--------");
                    Console.WriteLine("\n    Cadastro de Pessoas       ");
                    Console.WriteLine("--------------------------------------\n\n");
                    Person person = new Person();
                    Console.WriteLine(person.ToString());
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine(" Até mais :)");
                    break;

                default:
                    Console.WriteLine("Escolha um exercício existente.");
                    Console.ReadKey();
                    break;
            }
        } while (ex != 4);

        void Saque(double value)
        {
            balance = balance - value;
            Console.WriteLine("Foi realizado um saque, seu saldo é de: R$" + balance + ",00");
        }

        void Deposito(double value)
        {
            balance = balance + value;
            Console.WriteLine("Foi realizado um depósito, seu saldo é de: R$" + balance + ",00");

        }
    }
}
