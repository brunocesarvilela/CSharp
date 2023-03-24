using System;
namespace Aula08 {
    
    class Aula08 {
        
        static void Main(string[] args) {
           double v1,v2,soma;
           string nome;
           Console.Write("Digite seu nome: ");
           nome = Console.ReadLine();
           Console.WriteLine("Nome Digitado: {0}",nome);
           Console.Write("Digite o primeiro valor: ");
           v1 = Convert.ToDouble(Console.ReadLine());           
           Console.Write("Digite o segundo valor: ");
           v2 = Convert.ToDouble(Console.ReadLine());
           soma = v1+v2;
           Console.Write("O resultado é: {0}", soma);
        }
    }
}