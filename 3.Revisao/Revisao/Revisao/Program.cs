using Revisao;
using System.ComponentModel;

partial class Program
{
    static void Main(string[] args)
    {
        int idade = 0;
        string opcao;
        Console.WriteLine("digite sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        if (idade == 5)
        {
            Console.WriteLine("codigo encerrado");
        }
        while (true) {

            if (idade == 5)
            {
                break;
            }


            if (idade <= 18)
            {
                Console.WriteLine("vc é menor de idade ");
            }
            else
            {
                Console.WriteLine("você é maior de idade ");
            }

            switch (idade)
            {
                case <= 18: Console.WriteLine("novo");
                    break;
                case >= 18: Console.WriteLine("velho");
                    break;
            }
            Console.WriteLine($"Deseja continuar s/n");
            opcao = Console.ReadLine();
            if (opcao != "s")
            {
                break;
            }
            Console.Clear();
        }
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("lowcode");
        }
    }
}
