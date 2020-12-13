// <copyright file="BranchFactory.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Responsible for generating <see cref="Branch"/> instances.
    /// </summary>
    internal class BranchFactory
    {
        private readonly IFactory<BranchName> branchNameFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchFactory"/> class.
        /// </summary>
        /// <param name="branchNameFactory">The factory which provides <see cref="BranchName"/> instances.</param>
        public BranchFactory(IFactory<BranchName> branchNameFactory)
        {
            this.branchNameFactory = branchNameFactory;
        }

        /// <summary>
        /// Creates a new <see cref="Branch"/> instance which represents work for a feature.
        /// </summary>
        /// <returns>A new <see cref="Branch"/> instance.</returns>
        internal Branch CreateFeatureBranch()
        {
            return new Branch(path: $"feature/{this.branchNameFactory.Create()}");
        }

        /// <summary>
        /// Creates a new <see cref="Branch"/> instance which represents work for a fix.
        /// </summary>
        /// <returns>A new <see cref="Branch"/> instance.</returns>
        internal Branch CreateReleaseBranch()
        {
            return new Branch(path: $"release/{this.branchNameFactory.Create()}");
        }

        /// <summary>
        /// Creates a new <see cref="Branch"/> instance which has no sematic purpose.
        /// </summary>
        /// <returns>A new <see cref="Branch"/> instance.</returns>
        internal Branch CreateBranch()
        {
            return new Branch(path: this.branchNameFactory.Create().ToString());
        }
    }
}