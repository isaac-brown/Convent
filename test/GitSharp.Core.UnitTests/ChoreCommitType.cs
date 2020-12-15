// <copyright file="ChoreCommitType.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Represents a commit type for a commmit in which a chore has been performed. This could be
    /// linting, fixing spelling or some other task which doesn't fix an issue or add a feature.
    /// </summary>
    internal class ChoreCommitType : CommitType
    {
        /// <inheritdoc/>
        public override string Name => "chore";
    }
}