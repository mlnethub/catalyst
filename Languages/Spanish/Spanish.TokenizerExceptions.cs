
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class Spanish
    {
        internal sealed class TokenizerExceptions 
        {
            internal static Dictionary<int, TokenizationException> Get()
            {
                var exceptions = Catalyst.TokenizerExceptions.CreateBaseExceptions();

                Catalyst.TokenizerExceptions.Create(exceptions, "", "pal|pala", "para el|para la");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "aprox.|dna.|esq.|p�g.|p.ej.|Ud.|Vd.|Uds.|Vds.", "aproximadamente|docena|esquina|p�gina|por ejemplo|usted|usted|ustedes|ustedes");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "12m.", "12 p.m.");
                Catalyst.TokenizerExceptions.Create(exceptions, "", "a.C.|a.J.C.|apdo.|Av.|Avda.|C�a.|etc.|Gob.|Gral.|Ing.|J.C.|Lic.|m.n.|no.|n�m.|P.D.|Prof.|Profa.|q.e.p.d.|S.A.|S.L.|s.s.s.|Sr.|Sra.|Srta.", "a.C.|a.J.C.|apdo.|Av.|Avda.|C�a.|etc.|Gob.|Gral.|Ing.|J.C.|Lic.|m.n.|no.|n�m.|P.D.|Prof.|Profa.|q.e.p.d.|S.A.|S.L.|s.s.s.|Sr.|Sra.|Srta.");

                return exceptions;
            }
        }
    }
}
