using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoa.Model;

namespace Paciente.Model
{
    public class paciente : pessoa
    {
        public pessoa pes1;
        public string tiposanguineo { get; set; }
        public string convenio { get; set; }

        public paciente() 
        {
            tiposanguineo = "";
            convenio = "";
        }
    }
}
