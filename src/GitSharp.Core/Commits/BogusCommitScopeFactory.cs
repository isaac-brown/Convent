// <copyright file="BogusCommitScopeFactory.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.Commits
{
    using System.Linq;
    using Bogus;

    /// <summary>
    /// Implementation of <see cref="IFactory{T}"/> for <see cref="CommitScope"/> using <see cref="Bogus"/>.
    /// </summary>
    internal class BogusCommitScopeFactory : IFactory<CommitScope>
    {
        private readonly Faker<CommitScope> faker;

        /// <summary>
        /// Initializes a new instance of the <see cref="BogusCommitScopeFactory"/> class.
        /// </summary>
        public BogusCommitScopeFactory()
        {
            this.faker = new Faker<CommitScope>();
            this.faker.CustomInstantiator(f =>
            {
                string value = string.Join("-", f.Random.WordsArray(min: 1, max: 3).Select(s => s.Split(' ').First().ToLower()));
                return new CommitScope(value);
            });
        }

        /// <inheritdoc/>
        public CommitScope Create() => this.faker.Generate(count: 1).Single();
    }
}