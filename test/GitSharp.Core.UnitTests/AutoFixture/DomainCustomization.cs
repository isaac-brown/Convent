// <copyright file="DomainCustomization.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixture
{
    using global::AutoFixture;

    /// <summary>
    /// Provides GitSharp specific customizations to a <see cref="IFixture"/>.
    /// </summary>
    public class DomainCustomization : ICustomization
    {
        /// <inheritdoc/>
        public void Customize(IFixture fixture)
        {
            fixture.Register<BranchName>(() => BranchNameFaker.CreateOne());
            fixture.Register<CommitScope>(() => CommitScopeFaker.CreateOne());

            fixture.Register<IFactory<BranchName>, BogusBranchNameFactory>();

            fixture.Register<IFactory<CommitDescription>, BogusCommitDescriptionFactory>();
            fixture.Register<IFactory<CommitScope>, BogusCommitScopeFactory>();
        }
    }
}