// <copyright file="FixCommitType.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Convent.Commits
{
    /// <summary>
    /// Represents a commit type for a commit which fixes an issue.
    /// </summary>
    public sealed class FixCommitType : CommitType
    {
        /// <inheritdoc/>
        public override string Name => "fix";
    }
}