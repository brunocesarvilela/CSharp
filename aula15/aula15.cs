using System;
namespace Aula15 {
    
    class Aula15 {
        static void Main(string[] args) {
            int tempo=0;
            char escolha="";
            string seleciona = "";
            Console.WriteLine("BH a Vitória - ES");
            Console.WriteLine("Escolha o transporte: [a] avião | [c] carro | [o] onibus");
            seleciona = Console.ReadLine();
            escolha = (char) seleciona;
            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    break;
                case 'c':
                    tempo = 480;
                    break;
                case 'o':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;
            }
            if (tempo<0) {
                Console.WriteLine("Transporte Indisponível");
            } else {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
            }
        }
    }
}