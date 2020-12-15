// <copyright file="DomainCustomization.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixture
{
    using System.Collections.Generic;
    using System.Linq;
    using global::AutoFixture;
    using MoreLinq;

    /// <summary>
    /// Provides GitSharp specific customizations to a <see cref="IFixture"/>.
    /// </summary>
    public class DomainCustomization : ICustomization
    {
        private static readonly IEnumerable<CommitType> CommitTypes = new CommitType[] { new FeatureCommitType(), new FixCommitType(), new ChoreCommitType() };

        /// <inheritdoc/>
        public void Customize(IFixture fixture)
        {
            fixture.Register<BranchName>(() => BranchNameFaker.CreateOne());
            fixture.Register<CommitScope>(() => CommitScopeFaker.CreateOne());
            fixture.Register<CommitType>(() => CommitTypeFaker.CreateOne());

            fixture.Register<IFactory<BranchName>, BogusBranchNameFactory>();

            fixture.Register<IFactory<CommitDescription>, BogusCommitDescriptionFactory>();
            fixture.Register<IFactory<CommitScope>, BogusCommitScopeFactory>();
        }
    }
}