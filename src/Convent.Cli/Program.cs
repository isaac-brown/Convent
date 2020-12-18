// <copyright file="Program.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Convent.Cli
{
    using System;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using System.Linq;
    using System.Threading.Tasks;
    using Convent.Commits;

    /// <summary>
    /// Entrypoint for the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entrypoint for the application.
        /// </summary>
        /// <param name="args">The arguments for the application.</param>
        /// <returns>A <see cref="Task"/> representing the outcome of the application.</returns>
        public static async Task Main(string[] args)
        {
            var rootCommand = new RootCommand()
            {
                new Command("feature")
                {
                    Description = "Creates a random feature commit message.",
                    Handler = CommandHandler.Create<SharedCommandOptions>(HandleFeatureCommand),
                },
                new Command("fix")
                {
                    Description = "Creates a random fix commit message.",
                    Handler = CommandHandler.Create<SharedCommandOptions>(HandleFixCommand),
                },
                new Command("chore")
                {
                    Description = "Creates a random chore commit message.",
                    Handler = CommandHandler.Create<SharedCommandOptions>(HandChoreCommand),
                },
            };

            var options = new[]
            {
                new Option<bool>(
                    aliases: new[] { "--scope", "-s" },
                    getDefaultValue: () => false,
                    description: "When true, adds a scope element to the commit message"),
                new Option<bool>(
                    aliases: new[] { "--body", "-b" },
                    getDefaultValue: () => false,
                    description: "When true, adds a body element to the commit message"),
                new Option<bool>(
                    aliases: new[] { "--issue", "-i" },
                    getDefaultValue: () => false,
                    description: "When true, adds an issue element to the commit message"),
                new Option<bool>(
                    aliases: new[] { "--breaking-change" },
                    getDefaultValue: () => false,
                    description: "When true, adds a breaking change element to the commit message"),
            };

            foreach (var childCommand in rootCommand.Children.OfType<Command>())
            {
                foreach (var option in options)
                {
                    childCommand.AddOption(option);
                }
            }

            await rootCommand.InvokeAsync(args);
        }

        private static void HandleFixCommand(SharedCommandOptions sharedCommandOptions)
        {
            HandleCommitCommand(new FixCommitType(), sharedCommandOptions);
        }

        private static void HandChoreCommand(SharedCommandOptions sharedCommandOptions)
        {
            HandleCommitCommand(new ChoreCommitType(), sharedCommandOptions);
        }

        private static void HandleFeatureCommand(SharedCommandOptions sharedCommandOptions)
        {
            HandleCommitCommand(new FeatureCommitType(), sharedCommandOptions);
        }

        private static void HandleCommitCommand(CommitType commitType, SharedCommandOptions sharedCommandOptions)
        {
            var messageFactory = new ConventionalCommitMessageFactory();
            var commitMessageOptions = sharedCommandOptions.ToCommitMessageOptions();
            var commitMessage = messageFactory.CreateCommitMessage(commitType, commitMessageOptions);
            Console.WriteLine(commitMessage);
        }
    }
}
