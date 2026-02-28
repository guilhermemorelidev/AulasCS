namespace CursoProgramacao
{
    public class Aula2
    {
        int numero;
        int resultado;
        public void ValorPar()
        {
            Console.WriteLine("Digite um numero que deseja perguntar se é par ou impar");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero % 2;

            Console.WriteLine(resultado);

            if( resultado == 0)
            {
                Console.WriteLine("\nEsse numero é par");
            }
            else
            {
                Console.WriteLine("\nEsse numero é impar");
            }          
        }

        public void MaiorIdade()
        {
        
            Console.Write("Qual é sua idade\n");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.Write("Você é maior de idade \n");
            }
            else
            {
                Console.Write("Você é menor de idade \n");
            }
        }        
        public void NotaEscola()
        {
            // preciso receber a nota do aluno e depois vejo se ele passou ou nao
            Console.Write("Qual foi sua nota ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 7)
            {
                Console.Write("Aprovado Parabéns\n");
            }else if (nota >= 5)
            {
                Console.Write("Ficou de recuperação infelizmente\n");
            }
            else
            {
                Console.WriteLine("Você reprovou");
            }
        }
    }
}