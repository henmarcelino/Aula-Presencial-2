using Controllers.DAL;
using Modelos;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Controllers
{
    public class AlunosController
    {
        Contexto contexto = new Contexto();
        public void Inserir(Aluno novoAluno)
        {
            contexto.Alunos.Add(novoAluno);
            contexto.SaveChanges();
        }



        public List<Aluno> ListarTodos()
        {
            return contexto.Alunos.ToList();
        }

        public Aluno BuscarPorMatricula(int matricula)
        {
            // Usando LINQ
            var aluno = from a in contexto.Alunos
                        where a.Matricula == matricula
                        select a;
            return (Aluno)aluno;
        }

        public Aluno BuscarPorID(int idAluno)
        {
            return contexto.Alunos.Find(idAluno); // Pesquisa por chave primaria
        }

        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idAluno)
        {
            Aluno aluno = BuscarPorID(idAluno);
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }
    }
    /*public class AlunosController
    {

        List<Aluno> tabelaAlunos = new List<Aluno>();

        public void Inserir(Aluno a)
        {
            tabelaAlunos.Add(a);
        }

        public List<Aluno> ListarTodos()
        {
            return tabelaAlunos;
        }
    }*/
}
