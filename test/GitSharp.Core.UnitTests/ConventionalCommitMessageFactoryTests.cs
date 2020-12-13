// <copyright file="ConventionalCommitMessageFactoryTests.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    using FluentAssertions;
    using GitSharp.Core.UnitTests.AutoFixture;
    using global::AutoFixture;
    using Xunit;

    /// <summary>
    /// Unit tests for the <see cref="ConventionalCommitMessageFactory"/> class.
    /// </summary>
    public class ConventionalCommitMessageFactoryTests
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1600 // Elements must be documented
        [Fact]
        public void Given_a_valid_commit_description_When_CreateFeatureCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitDescription>, ConstantCommitDescriptionFactoryStub>();

            var description = fixture.Freeze<CommitDescription>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateFeatureCommitMessage();

            // Assert.
            commitMessage.Should()
                         .Be($"feat: {description}");
        }

        [Fact]
        public void Given_a_valid_commit_description_and_hasScope_is_true_When_CreateFeatureCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitScope>, ConstantCommitScopeFactoryStub>();

            var scope = fixture.Freeze<CommitScope>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateFeatureCommitMessage(hasScope: true);

            // Assert.
            commitMessage.Should()
                         .Match($"feat({scope}): *");
        }

        [Fact]
        public void Given_a_valid_commit_description_When_CreateFixCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitDescription>, ConstantCommitDescriptionFactoryStub>();

            var description = fixture.Freeze<CommitDescription>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateFixCommitMessage();

            // Assert.
            commitMessage.Should()
                         .Be($"fix: {description}");
        }

        [Fact]
        public void Given_a_valid_commit_description_and_hasScope_is_true_When_CreateFixCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitScope>, ConstantCommitScopeFactoryStub>();

            var scope = fixture.Freeze<CommitScope>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateFixCommitMessage(hasScope: true);

            // Assert.
            commitMessage.Should()
                         .Match($"fix({scope}): *");
        }

        [Fact]
        public void Given_a_valid_commit_description_When_CreateChoreCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitDescription>, ConstantCommitDescriptionFactoryStub>();

            var description = fixture.Freeze<CommitDescription>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateChoreCommitMessage();

            // Assert.
            commitMessage.Should()
                         .Be($"chore: {description}");
        }

        [Fact]
        public void Given_a_valid_commit_description_and_hasScope_is_true_When_CreateChoreCommitMessage_is_called_Then()
        {
            // Arrange.
            IFixture fixture = new Fixture().Customize(new DomainCustomization());
            fixture.Register<IFactory<CommitScope>, ConstantCommitScopeFactoryStub>();

            var scope = fixture.Freeze<CommitScope>();

            var sut = fixture.Create<ConventionalCommitMessageFactory>();

            // Act.
            var commitMessage = sut.CreateChoreCommitMessage(hasScope: true);

            // Assert.
            commitMessage.Should()
                         .Match($"chore({scope}): *");
        }
    }
}