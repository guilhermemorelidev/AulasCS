// primeiro pedir o peso e a altura 
// imc = peso / (altura*altura)
using System.Globalization;
using System.Xml.Serialization;

float peso, altura, imc;
while (true)
{
    Console.WriteLine("qual é seu peso ?? ");
    peso = float.Parse(Console.ReadLine());

    Console.WriteLine("qual é sua altura ?? ");
    altura = float.Parse(Console.ReadLine());

    imc = peso / (altura * altura);

    Console.WriteLine($"seu imc é {imc:F2}");

    if (imc >= 25)
    {
        Console.WriteLine("Você está obeso");
    }
    else if (imc <= 24.5)
    {
        Console.WriteLine("Seu peso está ideal");
    }
    else if (imc <= 18.5)
    {
        Console.WriteLine("você está abaixo do peso");
    }

    Console.WriteLine("Deseja sair  S/N?");
    string opcao = Console.ReadLine();

    if (opcao == "S") {
        break;
    }
    Console.Clear();
}