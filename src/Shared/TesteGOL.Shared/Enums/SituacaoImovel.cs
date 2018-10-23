using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum SituacaoImovel
    {
        [Description("DISPONÍVEL")]
        SiDisponivel = 1,
        [Description("INDISPONÍVEL")]
        SiIndisponivel = 2,
        [Description("EM NEGOCIAÇÃO")]
        SiNegociacao = 3,
        [Description("VENDIDO / ALUGADO")]
        SiVendidoAlugado = 4,
        [Description("NÃO APLICÁVEL")]
        SiNenhumaOpcao = 5
    }
}
