// <copyright file="ConstantBranchNameProviderStub.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Stub implementation of <see cref="IFactory{T}"/> (for <see cref="BranchName"/>) which always returns the same value.
    /// </summary>
    internal class ConstantBranchNameProviderStub : IFactory<BranchName>
    {
        private readonly BranchName branchName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantBranchNameProviderStub"/> class.
        /// </summary>
        /// <param name="branchName">The <see cref="BranchName"/> to always return.</param>
        public ConstantBranchNameProviderStub(BranchName branchName)
        {
            this.branchName = branchName;
        }

        /// <inheritdoc/>
        public BranchName Create() => this.branchName;
    }
}