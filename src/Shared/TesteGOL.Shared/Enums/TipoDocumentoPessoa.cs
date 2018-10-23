using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoDocumentoPessoa
    {
        [Description("FÍSICA")]
        TdpFisica = 1,
        [Description("JURÍDICA")]
        TdpJuridica = 2
    }
}
