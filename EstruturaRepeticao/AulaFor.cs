using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaRepeticao
{
    public class AulaFor
    {
        public void MetodoFor()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }

        }
        public void Tabuada()
        {
            int tabuada;
            Console.WriteLine("Informe o numero da tabuada");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
            }
        }
        public void SomaFor()
        {
            
            int valor, resultado = 0 ;
            for (int i = 1; i < 4; i++) {
                Console.WriteLine($"Infome o {i}° valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                resultado = valor + resultado;
                resultado = valor * resultado;

            }Console.WriteLine($"Total da soma é {resultado}");
        }   
        public void Desafio() {
            int valor = 0, resultado = 1 ;
            for (int i = 1; i < 4; i++) {
                Console.WriteLine($"Informe o {i}° valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                resultado = valor * resultado;
            }
            Console.WriteLine($"O resultado da multiplicação é {resultado} ");
        }
    }
}

