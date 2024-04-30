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
        /// <para><value>C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\</value></para>
        /// </summary>
        public IDirectoryPath CloudSharedDataDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\".ToDirectoryPath();
        /// <summary>
        /// <para><value>C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Output\</value></para>
        /// </summary>
        public IDirectoryPath CloudSharedOutputDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Output\".ToDirectoryPath();
        /// <summary>
        /// <para><value>C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances</value></para>
        /// </summary>
        public IDirectoryPath CloudSharedInstancesDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances\".ToDirectoryPath();
    }
}
