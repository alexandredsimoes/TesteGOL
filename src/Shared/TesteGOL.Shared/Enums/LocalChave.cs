using System.ComponentModel;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum LocalChave
    {
        [Description("IMOBILIÁRIA")]
        LcImobiliaria = 1,
        [Description("PROPRIETÁRIO")]
        LcProprietario = 2,
        [Description("INQUILINO")]
        LcInquilino = 3,
        [Description("OUTROS")]
        LcOutros = 4
    }
}
