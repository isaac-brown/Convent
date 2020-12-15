// <copyright file="CommitMessageOptions.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Represents options to be used when generating commit messages.
    /// </summary>
    internal class CommitMessageOptions
    {
        /// <summary>
        /// Gets a new <see cref="CommitMessageOptions"/> instance which has all flags set to true.
        /// </summary>
        public static CommitMessageOptions All => new CommitMessageOptions
        {
            HasScope = true,
            HasBody = true,
            HasIssue = true,
            HasBreakingChange = true,
        };

        /// <summary>
        /// Gets a new <see cref="CommitMessageOptions"/> instance which has default values.
        /// </summary>
        public static CommitMessageOptions Default => new CommitMessageOptions();

        /// <summary>
        /// Gets or sets a value indicating whether or not a scope should be included in a commit message.
        /// </summary>
        public bool HasScope { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether or not a scope should be included in a commit message.
        /// </summary>
        public bool HasBody { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether or not a scope should be included in a commit message.
        /// </summary>
        public bool HasIssue { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether or not a scope should be included in a commit message.
        /// </summary>
        public bool HasBreakingChange { get; set; } = false;

        /// <summary>
        /// Gets a value indicating whether or not a footer (i.e. issue or breaking change) should be included in a commit message.
        /// </summary>
        public bool HasFooter => this.HasIssue || this.HasBreakingChange;
    }
}