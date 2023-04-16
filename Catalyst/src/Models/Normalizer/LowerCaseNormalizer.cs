﻿using Mosaik.Core;
using System.Threading;
using System.Threading.Tasks;

namespace Catalyst.Models
{
    public class LowerCaseNormalizer : INormalizer, IProcess
    {
        public Language Language => Language.Any;
        public string Type => typeof(LowerCaseNormalizer).FullName;

        public string Tag => "";
        public int Version => 0;

        public static async Task<LowerCaseNormalizer> FromStoreAsync(Language language, int version, string tag)
        {
            return await Task.FromResult(new LowerCaseNormalizer());
        }

        public static async Task<bool> ExistsAsync(Language language, int version, string tag)
        {
            return true;
        } // Needs to say it exists, otherwise when calling ModelDescription.ExistsAsync(Language language, int version, string tag), it will fail to load this model

        public void Process(IDocument document, CancellationToken cancellationToken = default)
        {
            Normalize(document);
        }

        public void Normalize(IDocument document)
        {
            document.Value = document.Value.ToLowerInvariant();
        }

        public string Normalize(string text)
        {
            return text.ToLowerInvariant();
        }
    }
}