// <copyright file="ConventionalCommitMessageFactory.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Responsible for creating commit messages which conform to the conventional commit specification.
    /// </summary>
    internal class ConventionalCommitMessageFactory
    {
        private readonly IFactory<CommitDescription> commitDescriptionFactory;
        private readonly IFactory<CommitScope> commitScopeFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConventionalCommitMessageFactory"/> class.
        /// </summary>
        /// <param name="commitDescriptionFactory">The factory which will create <see cref="CommitDescription"/> instances.</param>
        /// <param name="commitScopeFactory">The factory which will create <see cref="CommitScope"/> instances.</param>
        public ConventionalCommitMessageFactory(
            IFactory<CommitDescription> commitDescriptionFactory,
            IFactory<CommitScope> commitScopeFactory)
        {
            this.commitDescriptionFactory = commitDescriptionFactory;
            this.commitScopeFactory = commitScopeFactory;
        }

        /// <summary>
        /// Creates a new commit message which represents the implementation of a single feature.
        /// </summary>
        /// <param name="hasScope">Whether or not a <see cref="CommitScope"/> should be included in the commit message.</param>
        /// <returns>A <see cref="string"/> representing a commit message.</returns>
        internal string CreateFeatureCommitMessage(bool hasScope = false)
        {
            return this.CreateTypedCommitMessage(type: "feat", hasScope);
        }

        /// <summary>
        /// Creates a new commit message which represents the implementation of a single fix.
        /// </summary>
        /// <param name="hasScope">Whether or not a <see cref="CommitScope"/> should be included in the commit message.</param>
        /// <returns>A <see cref="string"/> representing a commit message.</returns>
        internal string CreateFixCommitMessage(bool hasScope = false)
        {
            return this.CreateTypedCommitMessage(type: "fix", hasScope);
        }

        /// <summary>
        /// Creates a new commit message which represents the implementation of a single chore.
        /// </summary>
        /// <param name="hasScope">Whether or not a <see cref="CommitScope"/> should be included in the commit message.</param>
        /// <returns>A <see cref="string"/> representing a commit message.</returns>
        internal string CreateChoreCommitMessage(bool hasScope = false)
        {
            return this.CreateTypedCommitMessage(type: "chore", hasScope);
        }

        private string CreateTypedCommitMessage(string type, bool hasScope)
        {
            CommitDescription commitDescription = this.commitDescriptionFactory.Create();

            if (hasScope)
            {
                CommitScope commitScope = this.commitScopeFactory.Create();
                return $"{type}({commitScope}): {commitDescription}";
            }

            return $"{type}: {commitDescription}";
        }
    }
}