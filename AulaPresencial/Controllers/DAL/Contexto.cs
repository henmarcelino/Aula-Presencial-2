using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")  // base = (super do java), "strConn" = nome da conexão com banco
        {

        }

        public DbSet<Aluno> Alunos { get; set; }  // tabela de alunos
        public DbSet<Professor> Professores { get; set; } //tabela de professores
        public DbSet<Disciplina> Disciplinas { get; set; } // tabela de disciplinas
    }
   
}
