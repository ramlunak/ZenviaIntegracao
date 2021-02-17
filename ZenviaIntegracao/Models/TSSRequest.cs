using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ZenviaIntegracao.Models
{
    public class TSSRequest
    {
        [DefaultValue("5531982185513")]
        public string numero_destino { get; set; }
        [DefaultValue("oi , novo mensagem")]
        public string mensagem { get; set; }
        [DefaultValue("br-Vitoria")]
        public string tipo_voz { get; set; }
        [DefaultValue("4832830151")]
        public string bina { get; set; }
        public bool resposta_usuario { get; set; } = true;
        public bool gravar_audio { get; set; } = true;
        public bool detecta_caixa { get; set; } = true;
        public bool bina_inteligente { get; set; } = true;
    }
}
