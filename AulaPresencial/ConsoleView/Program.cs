using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = CadastrarAluno();

            ImprimirDadosAluno(a);

            Console.ReadKey();

            
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);
            Console.WriteLine("Matricula: " + a.Matricula);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine("Digite o Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());
            return a;
        }
    }
}
