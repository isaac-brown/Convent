// <copyright file="DomainCustomization.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    using System.Collections.Generic;
    using AutoFixture;
    using GitSharp.Core.Commits;
    using GitSharp.Core.UnitTests.Fakers;

    /// <summary>
    /// Provides GitSharp specific customizations to a <see cref="IFixture"/>.
    /// </summary>
    public class DomainCustomization : ICustomization
    {
        private static readonly IEnumerable<CommitType> CommitTypes = new CommitType[] { new FeatureCommitType(), new FixCommitType(), new ChoreCommitType() };

        /// <inheritdoc/>
        public void Customize(IFixture fixture)
        {
            // fixture.Register<CommitScope>(() => CommitScopeFaker.CreateOne());
            fixture.Register<CommitType>(() => CommitTypeFaker.CreateOne());
        }
    }
}