// <copyright file="CommitScopeFaker.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Bogus;

    /// <summary>
    /// Provides test data creation for the <see cref="CommitScope"/> class.
    /// </summary>
    internal static class CommitScopeFaker
    {
        private static readonly Faker<CommitScope> Faker;

        /// <summary>
        /// Initializes static members of the <see cref="CommitScopeFaker"/> class.
        /// </summary>
        static CommitScopeFaker()
        {
            Faker = new Faker<CommitScope>();

            Faker.CustomInstantiator(f =>
            {
                string value = f.Random.Words()
                                       .ToLower()
                                       .Replace(" ", "-");
                return new CommitScope(value);
            });
        }

        /// <summary>
        /// Creates one new well-formed <see cref="CommitScope"/> instance.
        /// </summary>
        /// <returns>A new <see cref="CommitScope"/> instance.</returns>
        internal static CommitScope CreateOne()
        {
            return CreateMany(count: 1).Single();
        }

        /// <summary>
        /// Creates zero one or many well-formed <see cref="CommitScope"/> instances.
        /// </summary>
        /// <param name="count">The total number of instances to create. Default is 10.</param>
        /// <returns>A collection of <see cref="CommitScope"/> instances.</returns>
        internal static IReadOnlyList<CommitScope> CreateMany(int count = 10)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("must be a positive integer", nameof(count));
            }

            return Faker.Generate(count);
        }
    }
}