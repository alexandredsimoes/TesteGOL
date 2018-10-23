using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoGarantiaPagamento
    {
        [Description("SEM GARANTIA DE PAGAMENTO")]
        TgpSemGarantia = 1,
        [Description("COM GARANTIA DE PAGAMENTO")]
        TgpComGarantia = 2
    }
}
