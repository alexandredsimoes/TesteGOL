using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum SituacaoContrato
    {
        [Description("ATIVO")]
        ScAtivo = 1,
        [Description("INATIVO")]
        ScInativo = 2,
        [Description("EM ACORDO")]
        ScAcordo = 3,
        [Description("AÇÃO JUDICIAL")]
        ScAcaoJudicial = 4
    }
}
