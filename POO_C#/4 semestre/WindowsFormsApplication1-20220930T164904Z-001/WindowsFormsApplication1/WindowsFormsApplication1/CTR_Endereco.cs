using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CTR_Endereco
    {
        public void crud()
        {
        }
        public int verifica_cep (Endereco end)
        {
            if (end.cep > 0)
                return 0;
            else 
                return 3;
        }
    }
}

