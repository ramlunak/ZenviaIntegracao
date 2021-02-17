using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenviaIntegracao.Models
{
    public class TSSResponse
    {
        public int status { get; set; }
        public bool sucesso { get; set; }
        public int motivo { get; set; }
        public string mensagem { get; set; }
        public TSSDados dados { get; set; }
    }
}
