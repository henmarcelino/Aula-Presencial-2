using Modelos;
using System.Collections.Generic;
using System;

namespace Controllers
{
    public class ProfessoresController
    {
        List<Professor> tabelaProfessores = new List<Professor>();

         public void Inserir(Professor a)
            {
                tabelaProfessores.Add(a);
            }

          public List<Professor> ListarTodos()
            {
                return tabelaProfessores;
            }
    }
    }

