using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSIXProject1
{
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidVSIXProject1PackageString = "641260e7-1b62-4d3e-a8a5-243409f90935";
        public static Guid guidVSIXProject1Package = new Guid(guidVSIXProject1PackageString);

        public const string guidVSIXProject1PackageCmdSetString = "02560bbd-a5ff-4c2b-a768-443a890d68d2";
        public static Guid guidVSIXProject1PackageCmdSet = new Guid(guidVSIXProject1PackageCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenuGroup = 0x1020;
        public const int Command1Id = 0x0100;
    }
}
