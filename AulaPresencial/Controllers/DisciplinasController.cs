using Modelos;
using System.Collections.Generic;
using System;
using Controllers.DAL;
using System.Data;
using System.Linq;

namespace Controllers
{
    public class DisciplinasController
    {
        Contexto contexto = new Contexto();
        public void Inserir (Disciplina novoDisciplina)
        {
            contexto.Disciplinas.Add(novoDisciplina);
            contexto.SaveChanges();
        }
        
        public List<Disciplina> ListarTodos()
        {
            return contexto.Disciplinas.ToList();
        }

        public Disciplina BuscarPorMateria(int Ciclo)
        {
            // Usando LINQ
            var disciplina = from a in contexto.Disciplinas
                            where a.Ciclo == Ciclo
                            select a;
            return (Disciplina)disciplina;
        }

        public Disciplina BuscarPorID(int idDisciplina)
        {
            return contexto.Disciplinas.Find(idDisciplina); // Pesquisa por chave primaria
        }

        public void Atualizar(Disciplina disciplina)
        {
            contexto.Entry(disciplina).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int idDisciplina)
        {
            Disciplina disciplina = BuscarPorID(idDisciplina);
            contexto.Disciplinas.Remove(disciplina);
            contexto.SaveChanges();
        }
    }
}
