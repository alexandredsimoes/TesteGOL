using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoGarantiaContrato
    {
        [Description("FIADOR")]
        TgcFiador = 1,
        [Description("SEGURO")]
        TgcSeguro = 2,
        [Description("CAUÇÃO")]
        TgcCaucao = 3,
        [Description("NÃO APLICÁVEL")]
        TgcNaoAplicavel = 4
    }
}
