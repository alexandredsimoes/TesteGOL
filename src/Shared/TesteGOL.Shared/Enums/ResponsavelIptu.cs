using System.ComponentModel;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum ResponsavelIptu
    {
        [Description("NÃO APLICÁVEL")]
        RiNaoAplicavel,
        [Description("PROPRIETÁRIO")]
        RiProprietario,
        [Description("INQUILINO")]
        RiInquilino        
    }
}