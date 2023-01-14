using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoa.Model;

namespace Medico.Model
{
    internal class medico : pessoa
    {
        public int CRM { get; set; }
        public string especialidade { get; set; }

        public medico() 
        {
            CRM = 0;
            especialidade = "";
        }
    }
}
