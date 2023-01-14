using Pessoa.Dao;
using Pessoa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa.Control
{
    internal class CTR_Pessoa
    {
        Dao_pessoa Dao_pessoa;

        public CTR_Pessoa(string banco)
        {
            Dao_pessoa = new Dao_pessoa(banco);
        }

        public void C_novo(pessoa pessoa)
        {
            Dao_pessoa.create(pessoa);
        }

        public pessoa R_buscar(pessoa pessoa)
        {
            return Dao_pessoa.read(pessoa);
        }

        public void U_altera(pessoa pessoa)
        {
            Dao_pessoa.update(pessoa);
        }

        public void D_exclui(pessoa pessoa)
        {
            Dao_pessoa.delete(pessoa);
        }
    }
}
