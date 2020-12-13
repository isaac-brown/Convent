// <copyright file="BranchFactoryTests.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    using FluentAssertions;
    using GitSharp.Core.UnitTests.AutoFixture;
    using global::AutoFixture;
    using Xunit;

    /// <summary>
    /// Unit tests for the <see cref="BranchFactory"/> class.
    /// </summary>
    public class BranchFactoryTests
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1600 // Elements must be documented
        [Fact]
        public void Given_a_valid_branch_name_When_CreateFeatureBranch_is_called_Then_resulting_path_should_be_feature_slash_branch_name()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<BranchName>, ConstantBranchNameProviderStub>();

            var branchName = fixture.Freeze<BranchName>();

            var sut = fixture.Create<BranchFactory>();

            // Act.
            var branch = sut.CreateFeatureBranch();

            // Assert.
            branch.Path.Should()
                       .Be($"feature/{branchName}");
        }

        [Fact]
        public void Given_a_valid_branch_name_When_CreateReleaseBranch_is_called_Then_resulting_path_should_be_release_slash_branch_name()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<BranchName>, ConstantBranchNameProviderStub>();

            var branchName = fixture.Freeze<BranchName>();

            var sut = fixture.Create<BranchFactory>();

            // Act.
            var branch = sut.CreateReleaseBranch();

            // Assert.
            branch.Path.Should()
                       .Be($"release/{branchName}");
        }

        [Fact]
        public void Given_a_valid_branch_name_When_CreateBranch_is_called_Then_resulting_path_should_be_branch_name()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<BranchName>, ConstantBranchNameProviderStub>();

            var branchName = fixture.Freeze<BranchName>();

            var sut = fixture.Create<BranchFactory>();

            // Act.
            var branch = sut.CreateBranch();

            // Assert.
            branch.Path.Should()
                       .Be(branchName.Value);
        }
    }
}
