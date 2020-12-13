// <copyright file="Branch.cs" company="Isaac Brown">
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace GitSharp.Core.UnitTests
{
    /// <summary>
    /// Represents a branch.
    /// </summary>
    internal class Branch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Branch"/> class.
        /// </summary>
        /// <param name="path">The path of tha branch.</param>
        public Branch(string path)
        {
            this.Path = path;
        }

        /// <summary>
        /// Gets the full path of the branch (e.g. "folder/sub-folder/branch-name").
        /// </summary>
        public string Path { get; }
    }
}