using System;

namespace McVersionsLib.Core
{
    [Serializable]
    public class VersionNotFoundException : Exception
    {
        public VersionNotFoundException() : base() { }
        public VersionNotFoundException(string message) : base(message) { }
    }
}
