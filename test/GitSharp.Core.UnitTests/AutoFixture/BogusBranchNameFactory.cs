// <copyright file="BogusBranchNameFactory.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixture
{
    using System.Linq;
    using Bogus;

    /// <summary>
    /// Implementation of <see cref="IFactory{T}"/> for <see cref="BranchName"/> using <see cref="Bogus"/>.
    /// </summary>
    internal class BogusBranchNameFactory : IFactory<BranchName>
    {
        private readonly Faker<BranchName> faker;

        /// <summary>
        /// Initializes a new instance of the <see cref="BogusBranchNameFactory"/> class.
        /// </summary>
        public BogusBranchNameFactory()
        {
            this.faker = new Faker<BranchName>();
            this.faker.CustomInstantiator(f =>
            {
                string words = f.Random.Words()
                                       .Replace(' ', '-')
                                       .ToLower();
                return new BranchName(words);
            });
        }

        /// <inheritdoc/>
        public BranchName Create()
        {
            return this.faker.Generate(count: 1).Single();
        }
    }
}