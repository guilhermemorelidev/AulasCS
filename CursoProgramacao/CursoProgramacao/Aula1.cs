namespace CursoProgramacao
{

    public class Aula1
    {
        int valor;
        int valor2;
        public void multiplicar()
        {
            Console.WriteLine("digite o primeiro valor ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo valor");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"o resultado é {valor * valor2}");
        }
        public void Soma()
        {
            Console.WriteLine("Informe o valor 1 ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor 2 ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Total: {valor + valor2}");
        }

        public void Subtrair()
        {
            Console.WriteLine("Informe o valor 1");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o valor 2 ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"se subtrairmos dá {valor - valor2}");
        }

        public void Dividir()
        {
            Console.WriteLine("Informe o valor 1 ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor <= 3)
            {
                Console.WriteLine("esse numero é maior que 3 ");
            }
            else
            {
                Console.WriteLine("esse numero é menor que 3 kkkkkkkkk");
            }

                Console.WriteLine($"Dividindo o resultado é {valor / valor2}");
        }

    }
}
