using System;


namespace R5T.L0001
{
    public static class RepositoryHelper
    {
        public const string NotFoundRepositoryDiscoveryResult = null;


        /// <summary>
        /// Evaluates the output of <see cref="LibGit2Sharp.Repository.Discover(string)"/> to determine if a repository was discovered.
        /// </summary>
        public static bool WasFound(string repositoryDiscoveryResult)
        {
            var wasFound = repositoryDiscoveryResult != RepositoryHelper.NotFoundRepositoryDiscoveryResult;
            return wasFound;
        }
    }
}
