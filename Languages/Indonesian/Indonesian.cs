
using System;
using System.Collections.Generic;
using Catalyst;
using Mosaik.Core;

namespace Catalyst.Models
{
    public static partial class Indonesian
    {
        public static void Register()
        {
            ObjectStore.OverrideModel(new AveragePerceptronTagger(Language.Indonesian, 0).GetStoredObjectInfo(),                                                                             async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "tagger.bin",                  async (s) => { var a = new AveragePerceptronTagger(Language.Indonesian, 0, "");                                                                          await a.LoadAsync(s); return a; }));
            ObjectStore.OverrideModel(new AveragePerceptronDependencyParser(Language.Indonesian, 0).GetStoredObjectInfo(),                                                                   async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "parser.bin",                  async (s) => { var a = new AveragePerceptronDependencyParser(Language.Indonesian, 0, "");                                                                await a.LoadAsync(s); return a; }));
            ObjectStore.OverrideModel(new SentenceDetector(Language.Indonesian, 0).GetStoredObjectInfo(),                                                                                    async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "sentence-detector.bin",       async (s) => { var a = new SentenceDetector(Language.Indonesian, 0, "");                                                                                 await a.LoadAsync(s); return a; }));
            ObjectStore.OverrideModel(new SentenceDetector(Language.Indonesian, 0, "lower").GetStoredObjectInfo(),                                                                           async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "sentence-detector-lower.bin", async (s) => { var a = new SentenceDetector(Language.Indonesian, 0, "");                                                                                 await a.LoadAsync(s); return a; }));
            ObjectStore.OverrideModel(new SentenceDetector(Language.Indonesian, 0, "upper").GetStoredObjectInfo(),                                                                           async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "sentence-detector-upper.bin", async (s) => { var a = new SentenceDetector(Language.Indonesian, 0, "");                                                                                 await a.LoadAsync(s); return a; }));
            ObjectStore.OverrideModel(new AveragePerceptronEntityRecognizer(Language.Indonesian, 0, "WikiNER", new string[] { "Person", "Organization", "Location" }).GetStoredObjectInfo(), async () => await ResourceLoader.LoadAsync(typeof(Indonesian).Assembly, "wikiner.bin",                 async (s) => { var a = new AveragePerceptronEntityRecognizer(Language.Indonesian, 0, "WikiNER", new string[] { "Person", "Organization", "Location" });  await a.LoadAsync(s); return a; }));

            Catalyst.StopWords.Snowball.Register(Language.Indonesian, StopWords.Snowball);
            Catalyst.StopWords.Spacy.Register(Language.Indonesian, StopWords.Spacy);
            Catalyst.LemmatizerStore.Register(Language.Indonesian, new Lemmatizer());
            Catalyst.TokenizerExceptions.Register(Language.Indonesian, new Lazy<Dictionary<int, TokenizationException>>(() => TokenizerExceptions.Get(), isThreadSafe:true));
        }
    }
}
