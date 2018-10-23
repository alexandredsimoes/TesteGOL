using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoLancamentoFinanceiro
    {
        [Description("PARCELA")]
        TlfParcela = 1,
        [Description("AVULSO")]
        TlfAvulso = 2,
        [Description("DIVERSOS")]
        TlDiversos = 3
    }
}
