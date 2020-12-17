// <copyright file="RegisterExtension.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests.AutoFixtureExtensions
{
    using AutoFixture;

    /// <summary>
    /// Provides extension methods for registration in the AutoFixture library.
    /// </summary>
    public static class RegisterExtension
    {
        /// <summary>
        /// Registers a mapping from <typeparamref name="TAbstract"/> to <typeparamref name="TConcrete"/> with the
        /// given <paramref name="fixture"/>. This means that when you ask for a <typeparamref name="TAbstract"/> to
        /// be created, you will instead get a <typeparamref name="TConcrete"/> instance.
        /// </summary>
        /// <param name="fixture">The <see cref="IFixture"/> to register the mapping with.</param>
        /// <typeparam name="TAbstract">The abstract type.</typeparam>
        /// <typeparam name="TConcrete">The concrete type.</typeparam>
        /// <remarks>
        /// Pinched from https://blog.ploeh.dk/2010/04/06/MappingtypeswithAutoFixture/.
        /// </remarks>
        public static void Register<TAbstract, TConcrete>(this IFixture fixture)
            where TConcrete : TAbstract
        {
            fixture.Register<TAbstract>(() => fixture.Create<TConcrete>());
        }
    }
}