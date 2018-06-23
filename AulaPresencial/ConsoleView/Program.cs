using Controllers;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController alunosController = new AlunosController();

            // Cadastrando alunos
            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);

            

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }

            ProfessoresController professorController = new ProfessoresController();

            // Cadastrando professores
            Professor d = CadastrarProfessor();
            professorController.Inserir(a);

            foreach (Professor professor in professorController.ListarTodos())
            {
                ImprimirDadosProfessor(professor);
            }

            /*
            DisciplinasController disciplinaController = new DisciplinasController();

            //Cadastro disciplinas

            Disciplina e = CadastrarDisciplina();
            disciplinaController.Inserir(a);
            
            foreach (Disciplina disciplina in DisciplinasController.ListarTodos())
            {
                ImprimirDadosDisciplina(disciplina);
            }
             */



            // ImprimirDadosAluno(a);

            Console.ReadKey();

            
        }

        private static void ImprimirDadosProfessor(object professor)
        {
            Console.WriteLine("Professor: " + a.Nome);
            Console.WriteLine("Cadastro: " + a.Cadastro);
        }

        private static Professor CadastrarProfessor()
        {
            Professor a = new Professor();

            Console.WriteLine("Digite o Professor: ");
            a.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o Cadastro: ");
            a.Cadastro = int.Parse(Console.ReadLine());
            return a;
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
