using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa.Model
{
    public class pessoa
    {
        public string nome { get; set; }
        public int rg { get; set; }
        public int cpf { get; set; }
        public string sexo { get; set; }
        public int numero { get; set; }
        public int datanascimento { get; set; }
        public string endereco { get; set; }

        public pessoa()
        {
            nome = "";
            rg = 0;
            cpf = 0;
            numero = 0;
            sexo = "";
            datanascimento = 0;
            endereco = "";
        }
    }
}
