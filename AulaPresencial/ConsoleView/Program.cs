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
            Professor p = CadastrarProfessor();
            professorController.Inserir(p);

            foreach (Professor professor in professorController.ListarTodos())
            {
                ImprimirDadosProfessor(professor);
            }
        
            
            DisciplinasController disciplinaController = new DisciplinasController();

            //Cadastro disciplinas

            Disciplina d = CadastrarDisciplina();
            disciplinaController.Inserir(d);
            
            foreach (Disciplina disciplina in DisciplinasController.ListarTodos())
            {
                ImprimirDadosDisciplina(disciplina);
            }
             



            // ImprimirDadosAluno(a);

            Console.ReadKey();

            
        }

        private static void ImprimirDadosDisciplina(Disciplina disciplina)
        {
            Console.WriteLine("Materia: " + disciplina.Materia);
            Console.WriteLine("Ciclo: " + disciplina.Ciclo);
        }

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina a = new Disciplina();

            Console.WriteLine("Digite a Matéria: ");
            a.Disciplina = (Console.ReadLine());
            Console.WriteLine("Digite o Ciclo: ");
            a.Ciclo = int.Parse(Console.ReadLine());
        }

        private static void ImprimirDadosProfessor(Professor professor)
        {
            Console.WriteLine("Professor: " + professor.Nome);
            Console.WriteLine("Cadastro: " + professor.Cadastro);
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
