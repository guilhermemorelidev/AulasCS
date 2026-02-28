using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacao
{
   public class Aula3
    {
        //Switch

        public void SwitchCase()
        {
            int nota;
            Console.WriteLine("Informe sua nota ");
            nota = Convert.ToInt32(Console.ReadLine());

            switch (nota)
            {
                case >= 7:
                    Console.WriteLine("passou");
                    break;

                case >= 5:
                    Console.WriteLine("recuperação");
                    break;

                default:
                    Console.WriteLine("reprovou");
                    break;
            }
        }

        public void CategoriaIdade()
        {
            Console.WriteLine("Qual é sua idade");
            int idade = Convert.ToSByte(Console.ReadLine());

            switch (idade)
            {
                case >= 60 : Console.WriteLine("idoso");
                    break;
                case >= 30 : Console.WriteLine("Adulto");
                    break;
                case >= 20 : Console.WriteLine("Jovem");
                    break;
                case >= 10 : Console.WriteLine("Adolescente");
                    break;
                default: Console.WriteLine("Criança");
                    break;
            }
        }


        }
    }
