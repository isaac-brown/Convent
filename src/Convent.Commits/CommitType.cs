// <copyright file="CommitType.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Convent.Commits
{
    /// <summary>
    /// Base type which all other commit types should extend.
    /// </summary>
    public abstract class CommitType
    {
        /// <summary>
        /// Gets the name of the type.
        /// </summary>
        public abstract string Name { get; }

        /// <inheritdoc/>
        public sealed override string ToString()
        {
            return this.Name;
        }
    }
}