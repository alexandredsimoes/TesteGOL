using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoUsoImovel
    {
        [Description("MORADIA")]
        TuiMoradia = 1,
        [Description("INVESTIMENTO")]
        TuiInvestimento = 2,
        [Description("COMÉRCIO")]
        TuiComercio = 3
    }
}
