// <copyright file="FeatureCommitType.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Convent.Commits
{
    /// <summary>
    /// Represents a commit type for a commit which adds a feature.
    /// </summary>
    public sealed class FeatureCommitType : CommitType
    {
        /// <inheritdoc/>
        public override string Name => "feat";
    }
}