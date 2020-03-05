﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System.Composition;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Completion;

namespace Microsoft.CodeAnalysis.CSharp.Completion.Providers
{
    /// <summary>
    /// Provides a completion provider that always appears before any built-in completion provider. This completion
    /// provider does not provide any completions.
    /// </summary>
    [ExportCompletionProvider(nameof(FirstBuiltInCompletionProvider), LanguageNames.CSharp)]
    [Shared]
    internal sealed class FirstBuiltInCompletionProvider : CompletionProvider
    {
        [ImportingConstructor]
        public FirstBuiltInCompletionProvider()
        {
        }

        public override Task ProvideCompletionsAsync(CompletionContext context)
            => Task.CompletedTask;
    }
}
