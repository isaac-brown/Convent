// <copyright file="FeatureCommitType.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Represents a commit type for a commit which adds a feature.
    /// </summary>
    internal sealed class FeatureCommitType : CommitType
    {
        /// <inheritdoc/>
        public override string Name => "feat";
    }
}