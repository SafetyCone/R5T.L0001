using System;

using LibGit2Sharp;


namespace R5T.L0001
{
    public static class RepositoryHelper
    {
        public const string NotFoundRepositoryDiscoveryResult = null;


        /// <summary>
        /// Evaluates the output of <see cref="Repository.Discover(string)"/> to determine if a repository was discovered.
        /// </summary>
        public static bool WasFound(string repositoryDiscoveryResult)
        {
            var wasFound = repositoryDiscoveryResult != RepositoryHelper.NotFoundRepositoryDiscoveryResult;
            return wasFound;
        }

        public static bool TryDiscoverRepositoryPath(string path, out string repositoryPath)
        {
            repositoryPath = Repository.Discover(path);

            var wasFound = RepositoryHelper.WasFound(repositoryPath);
            return wasFound;
        }

        public static string DiscoverRepositoryPath(string path)
        {
            var wasFound = RepositoryHelper.TryDiscoverRepositoryPath(path, out var repositoryPath);
            if (!wasFound)
            {
                throw new InvalidOperationException($"No Git repository found for '{path}'.");
            }

            return repositoryPath;
        }
    }
}
