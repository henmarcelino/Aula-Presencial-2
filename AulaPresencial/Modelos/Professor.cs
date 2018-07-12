using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Professor
    {
            public int ProfessorID { get; set; }

            public string Nome { get; set; }

            //public int Cadastro { get; set; }

        [Required]
        public int Cadastro { get; set; }
    }
    }

