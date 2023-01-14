using Medico.Dao;
using Medico.Model;
using Paciente.Dao;
using Paciente.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medico.Control
{
    class CTR_Medico
    {
        Dao_Medico Dao_Medico;

        public CTR_Medico(string banco)
        {
            Dao_Medico = new Dao_Medico(banco);
        }

        public void C_novo(medico medico)
        {
            Dao_Medico.create(medico);
        }

        public medico R_buscar(medico medico)
        {
            return Dao_Medico.read(medico);
        }

        public void U_altera(medico medico)
        {
            Dao_Medico.update(medico);
        }

        public void D_exclui(medico medico)
        {
            Dao_Medico.delete(medico);
        }
    }
}
