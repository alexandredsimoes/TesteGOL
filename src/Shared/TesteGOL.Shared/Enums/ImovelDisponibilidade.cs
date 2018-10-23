using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum ImovelDisponibilidade
    {
        [Description("LOCAÇÃO")]
        IdLocacao = 1,
        [Description("VENDA")]
        IdVenda = 2,
        [Description("AMBOS")]
        IdAmbos = 3
    }
}
