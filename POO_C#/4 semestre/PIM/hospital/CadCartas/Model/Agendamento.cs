using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paciente.Model;

namespace Agendamento.Model
{
    internal class agendamento : paciente
    {
        public int data { get; set; }
        public int horario { get; set; }
        public string local { get; set; }
        public string medico { get; set; }

        public agendamento() 
        {
            data = 0;
            horario = 0;
            local = "";
            medico = "";
        }
    }
}
