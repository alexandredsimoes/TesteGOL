using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoConta
    {
        [Description("CONTA CORRENTE")]
        TcContaCorrente = 1,
        [Description("CONTA POUPANÇA")]
        TcContaPoupanca = 2,
        [Description("CONTA INVESTIMENTO")]
        TcContaInvestimento = 3,
    }
}
