using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Aluno
    {
        public int AlunoID { get; set; }

        public string Nome { get; set; }

        [Required]
        public int Matricula { get; set; }
    }
}
