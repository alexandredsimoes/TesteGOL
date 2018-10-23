using System.ComponentModel;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum FinalidadeContrato
    {
        [Description("LOCADOR(A)")]
        FcLocador = 1,
        [Description("LOCATÁRIO(A)")]
        FcLocatario = 2,
        [Description("FIADOR(A)")]
        FcFiador = 3,
        [Description("COMPRADOR(A)")]
        FcComprador = 4,
        [Description("VENDEDOR(A)")]
        FcVendedor = 5,
        [Description("PROCURADOR(A)")]
        FcProcurador = 6
    }
}