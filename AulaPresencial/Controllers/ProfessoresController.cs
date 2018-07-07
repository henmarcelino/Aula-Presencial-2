using Modelos;
using System.Collections.Generic;
using System;
using Controllers.DAL;
using System.Data;
using System.Linq;

namespace Controllers
{
    public class ProfessoresController
    {
        Contexto contexto = new Contexto();
        public void Inserir (Professor novoProfessor)
        {
            contexto.Professores.Add(novoProfessor);
            contexto.SaveChanges();
        }

        public List<Professor> ListarTodos()
        {
            return contexto.Professores.ToList();
        }

        public Professor BuscarPorMatricula(int Cadastro)
        {
            // Usando LINQ
            var professor = from a in contexto.Professores
                        where a.Cadastro == Cadastro
                        select a;
            return (Professor)professor;
        }

        public Professor BuscarPorID(int idProfessor)
        {
            return contexto.Professores.Find(idProfessor); // Pesquisa por chave primaria
        }

        public void Atualizar(Professor professor)
        {
            contexto.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idProfessor)
        {
            Professor professor = BuscarPorID(idProfessor);
            contexto.Professores.Remove(professor);
            contexto.SaveChanges();
        }

        /*List<Professor> tabelaProfessores = new List<Professor>();

         public void Inserir(Professor a)
            {
                tabelaProfessores.Add(a);
            }

          public List<Professor> ListarTodos()
            {
                return tabelaProfessores;
            }*/
    }
    }

