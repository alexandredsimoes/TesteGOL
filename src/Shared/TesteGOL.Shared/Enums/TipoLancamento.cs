using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoLancamento
    {
        [Description("ENTRADA")]
        TcEntrada = 1,
        [Description("SAÍDA")]
        TcSaida = 2,
        [Description("NEUTRO")]
        TcNeutro = 3
    }
}
