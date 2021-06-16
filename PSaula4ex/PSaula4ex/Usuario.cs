using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSaula4ex
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Ativo { get; set; }
        
        public string SituacaoExibicao
        {
            get
            {
                if (Ativo == "A")
                    return "Ativo";
                else if (Ativo == "I")
                    return "Inativo";

                return "";
            }
        }

    }
}
