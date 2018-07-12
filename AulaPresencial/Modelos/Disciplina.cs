using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        
        public string Materia { get; set; }

        //public string Professor { get; set; }

        //public int Aluno { get; set; }

        [Required]
        public int Ciclo { get; set; }
    }
}
