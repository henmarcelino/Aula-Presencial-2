using Modelos;
using System.Collections.Generic;
using System;

namespace Controllers
{
    public class AlunosController
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
    }
}
