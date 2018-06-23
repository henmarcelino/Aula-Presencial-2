using Modelos;
using System.Collections.Generic;
using System;

namespace Controllers
{
    public class DisciplinasController
    {
        List<Disciplina> tabelaDisciplinas = new List<Disciplina>();

        public void Inserir(Disciplina a)
        {
            tabelaDisciplinas.Add(a);
        }

        public List<Disciplina> ListarTodos()
        {
            return tabelaDisciplinas;
        }
    }
}
