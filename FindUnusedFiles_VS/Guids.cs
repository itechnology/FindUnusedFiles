// Guids.cs
// MUST match guids.h

using System;

namespace ITechnologyNET.FindUnusedFiles
{
    static class GuidList
    {
        public const string guidFindUnusedFilesPkgString = "0cf7b733-7d9b-45b9-9aa8-328afd40580a";
        public const string guidFindUnusedFilesCmdSetString = "3924aca3-a84e-48af-905b-47b582ff9f5e";

        public static readonly Guid guidFindUnusedFilesCmdSet = new Guid(guidFindUnusedFilesCmdSetString);
    };
}