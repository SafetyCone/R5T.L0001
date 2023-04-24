using System;

using R5T.T0131;


namespace R5T.L0001.Z000
{
    [ValuesMarker]
    public interface IValues : IValuesMarker
    {
        /// <summary>
        /// The result of <see cref="LibGit2Sharp.Repository.Discover(string)"/> when the input path is not found to be part of a repository working directory.
        /// </summary>
        public string RepositoryDiscoverNotFoundResult => null;
    }
}
