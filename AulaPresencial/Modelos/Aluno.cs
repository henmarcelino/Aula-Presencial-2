using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    /*Context ctx = new Context();
        ctx.Aluno.add(novoAluno);
        ctx.savechanges();*/
    public class Aluno
    {
        public string Nome { get; set; }

        public int Matricula { get; set; }
    }
}
