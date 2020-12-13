// <copyright file="ConstantCommitScopeFactoryStub.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Stub implementation of <see cref="IFactory{T}"/> (for <see cref="CommitScope"/>) which always returns the same value.
    /// </summary>
    internal class ConstantCommitScopeFactoryStub : IFactory<CommitScope>
    {
        private readonly CommitScope commitScope;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantCommitScopeFactoryStub"/> class.
        /// </summary>
        /// <param name="commitScope">The <see cref="CommitScope"/> to always return.</param>
        public ConstantCommitScopeFactoryStub(CommitScope commitScope)
        {
            this.commitScope = commitScope;
        }

        /// <inheritdoc/>
        public CommitScope Create()
        {
            return this.commitScope;
        }
    }
}