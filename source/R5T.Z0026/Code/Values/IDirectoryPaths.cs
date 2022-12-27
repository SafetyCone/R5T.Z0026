using System;

using R5T.T0131;


namespace R5T.Z0026
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        public string CloudSharedOutputDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Output\";
        public string CloudSharedInstancesDirectoryPath => @"C:\Users\David\Dropbox\Organizations\Rivet\Shared\Data\Instances";
    }
}
