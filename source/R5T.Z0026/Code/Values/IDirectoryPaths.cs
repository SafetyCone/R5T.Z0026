using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0026
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\
        /// </summary>
        public IDirectoryPath CloudSharedData => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\".ToDirectoryPath();
        /// <summary>
        /// C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Output\
        /// </summary>
        public IDirectoryPath CloudSharedOutputDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Output\".ToDirectoryPath();
        /// <summary>
        /// C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances
        /// </summary>
        public IDirectoryPath CloudSharedInstancesDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances".ToDirectoryPath();
    }
}
