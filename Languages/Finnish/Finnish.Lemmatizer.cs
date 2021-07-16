
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class Finnish
    {
        internal sealed class Lemmatizer : ILemmatizer
        {
            public Language Language => Language.Finnish;

            public string GetLemma(IToken token)
            {
                return new string(GetLemmaAsSpan(token));
            }

            public ReadOnlySpan<char> GetLemmaAsSpan(IToken token)
            {
                return token.ValueAsSpan;
            }

            public bool IsBaseForm(IToken token)
            {
                return false;
            }
        }
    }
}
