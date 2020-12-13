// <copyright file="BranchNameFaker.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixture
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Bogus;

    /// <summary>
    /// Provides test data creation for the <see cref="BranchName"/> class.
    /// </summary>
    internal static class BranchNameFaker
    {
        private static readonly Faker<BranchName> Faker;

        static BranchNameFaker()
        {
            Faker = new Faker<BranchName>();
            Faker.CustomInstantiator(f =>
            {
                var words = f.Random.Words()
                                    .ToLower()
                                    .Replace(' ', '-');

                return new BranchName(value: words);
            });
        }

        /// <summary>
        /// Creates one new well-formed <see cref="BranchName"/> instance.
        /// </summary>
        /// <returns>A new <see cref="BranchName"/> instance.</returns>
        internal static BranchName CreateOne()
        {
            return CreateMany(count: 1).Single();
        }

        /// <summary>
        /// Creates zero one or many well-formed <see cref="BranchName"/> instances.
        /// </summary>
        /// <param name="count">The total number of instances to create. Default is 10.</param>
        /// <returns>A collection of <see cref="BranchName"/> instances.</returns>
        internal static IReadOnlyList<BranchName> CreateMany(int count = 10)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("must be a positive integer", nameof(count));
            }

            return Faker.Generate(count);
        }
    }
}