using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoEndereco
    {
        [Description("COMERCIAL")]
        TeComercial = 1,
        [Description("RESIDENCIAL")]
        TeResidencial = 2,
        [Description("OUTROS")]
        TeOutros = 3
    }
}
