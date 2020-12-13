// <copyright file="BranchName.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Represents the name for a <see cref="Branch"/>.
    /// </summary>
    internal class BranchName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchName"/> class.
        /// </summary>
        /// <param name="value">The name of the branch.</param>
        public BranchName(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value of the <see cref="BranchName"/>.
        /// </summary>
        public string Value { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is BranchName other)
            {
                return this.Value.Equals(other.Value);
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Value;
        }
    }
}