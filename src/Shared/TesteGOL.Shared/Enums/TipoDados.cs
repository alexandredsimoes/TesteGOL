using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum TipoDados
    {
        [Description("SIM/NÃO")]
        TdSimNao,
        [Description("NÚMERO")]
        TdNumero,
        [Description("TEXTO LIVRE")]
        TdTexto,
        [Description("LISTA DE OPÇÕES")]
        TdListaOpcoes
    }
}
