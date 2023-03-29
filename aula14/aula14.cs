using System;
namespace Aula14 {
    
    class Aula14 {
        static void Main(string[] args) {
            int nota = 0;
            string resultado;
            Console.WriteLine("Digite a nota do aluno: ");
            nota = int.Parse(Console.ReadLine());
            Console.WriteLine("A nota é {0}", nota);
            if (nota<40) {
                resultado = "Reprovado";
                Console.WriteLine(resultado);
            } else if (nota<60){
                resultado = "Recuperação";
                Console.WriteLine(resultado);
            } else {
                resultado = "Aprovado";
                Console.WriteLine(resultado);
            }
        }
    }
}