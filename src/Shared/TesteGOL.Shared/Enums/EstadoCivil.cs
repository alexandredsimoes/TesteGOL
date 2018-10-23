using System;
using System.ComponentModel;

namespace MiniApps.Imovel.Shared.Enums
{
    public enum EstadoCivil
    {
        [Description("SOLTEIRO(A)")]
        EcSolteiro = 1,
        [Description("CASADO(A)")]
        EcCasado = 2,
        [Description("DIVORCIADO(A)")]
        EcDivorciado = 3,
        [Description("VIÚVO(A)")]
        EcViuvo = 4,
        [Description("SEPARADO(A)")]
        EcSeparado = 5
    }
}
