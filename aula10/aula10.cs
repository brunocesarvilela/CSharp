using System;
namespace Aula10 {
    
    class Aula10 {
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
        static void Main(string[] args) {
           DiasSemana ds = (DiasSemana)3;
           Console.WriteLine(ds);
           int ds2 = (int) DiasSemana.Sexta;
           Console.WriteLine(ds2);
        }
    }
}