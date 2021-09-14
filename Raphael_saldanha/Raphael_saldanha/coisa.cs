using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raphael_saldanha
{
    public class coisa
    {
        public coisa()
        {
            this.nome = "ND";
        }

        public coisa(string v)
        {
            this.nome = v;
        }

        public string nome { get; set; }

        public string GetNome()
        {
            return this.nome;
        }
    }
}
