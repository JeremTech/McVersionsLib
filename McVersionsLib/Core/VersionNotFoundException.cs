using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace McVersionsLib.Core
{
    [Serializable]
    public class VersionNotFoundException : Exception
    {
        public VersionNotFoundException() : base() { }
        public VersionNotFoundException(string message) : base(message) { }
    }
}
