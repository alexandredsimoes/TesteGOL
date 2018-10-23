using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoLigacao
    {
        [Description("LOCAÇÃO")]
        TlLocacao = 1,
        [Description("VENDA")]
        TlVenda = 2,
        [Description("COMPRA")]
        TlCompra = 3,
        [Description("DIRETO")]
        TlDireto = 4,
        [Description("DIRETO")]
        TlRecado = 5,
        [Description("INFORMAÇÃO")]
        TlInformacao = 6

    }
}
