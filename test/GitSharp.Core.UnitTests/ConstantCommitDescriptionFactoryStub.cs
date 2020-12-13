// <copyright file="ConstantCommitDescriptionFactoryStub.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Stub implementation of <see cref="IFactory{T}"/> (for <see cref="CommitDescription"/>) which always returns the same value.
    /// </summary>
    internal class ConstantCommitDescriptionFactoryStub : IFactory<CommitDescription>
    {
        private readonly CommitDescription commitDescription;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantCommitDescriptionFactoryStub"/> class.
        /// </summary>
        /// <param name="commitDescription">The <see cref="CommitDescription"/> to always return.</param>
        public ConstantCommitDescriptionFactoryStub(CommitDescription commitDescription)
        {
            this.commitDescription = commitDescription;
        }

        /// <inheritdoc/>
        public CommitDescription Create()
        {
            return this.commitDescription;
        }
    }
}