using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paciente.Model;
using Paciente.Dao;


namespace Paciente.Control
{
    class CTR_paciente
    {
        Dao_paciente Dao_paciente;

        public CTR_paciente(string banco)
        {
            Dao_paciente = new Dao_paciente(banco);
        }

        public void C_novo(paciente paciente)
        {
            Dao_paciente.create(paciente);
        }

        public paciente R_buscar(paciente paciente)
        {
            return Dao_paciente.read(paciente);
        }

        public void U_altera(paciente paciente)
        {
            Dao_paciente.update(paciente);
        }

        public void D_exclui(paciente paciente)
        {
            Dao_paciente.delete(paciente);
        }
    }
}
