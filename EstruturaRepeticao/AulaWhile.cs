namespace EstruturaRepeticao
{
    public class AulaWhile
    {
        public void MetodoWhile()
        {
            Console.WriteLine("Qual numero você deseja na tabuada: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{valor}X{i} = {valor * i}");
                i++;

            }
        }

        public void Calculos()
        {
            String operacao;
            int v1 = 0; int v2 = 0;

            Calculos calculos = new Calculos();

            while (true)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("|Informe + para soma         |");
                Console.WriteLine("|Informe x para multiplicação|");
                Console.WriteLine("|Informe - para subtrair     |");
                Console.WriteLine("|Informe / para dividir      |");
                Console.WriteLine("|Pressione s para sair       |");
                Console.WriteLine("==============================");
                Console.Write("Operação: ");
                operacao = Console.ReadLine();

                Console.Clear();

                Console.Write("Informe o primeiro valor: ");
                v1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o segundo valor: ");
                v2 = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case "+":
                        Console.WriteLine("Soma: " + calculos.Soma(v1, v2));
                        break;
                    case "x":
                        Console.WriteLine("Multiplicação: " + calculos.Multiplicar(v1, v2));
                        break;
                    case "-":
                        Console.WriteLine("Subtrair: " + calculos.Subtrair(v1, v2));
                        break;
                    case "/":
                        Console.WriteLine("Divisão: " + calculos.Dividir(v1, v2));
                        break;
                    default:
                        Console.WriteLine("Selecione uma das opções validas ");
                        break;
                }

                Console.WriteLine("Deseja encerrar ? s/n");
                operacao = Console.ReadLine();
                if (operacao == "s")
                {
                    break;
                }

            }
        }
    }
}
