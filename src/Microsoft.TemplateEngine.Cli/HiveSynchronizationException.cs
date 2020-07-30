using System;

namespace Microsoft.TemplateEngine.Cli
{
    public sealed class HiveSynchronizationException : Exception
    {
        public HiveSynchronizationException(string message, string version)
            : base(message)
        {
            SdkVersion = version;
        }

        public HiveSynchronizationException(string message, string version, Exception innerException)
            : base(message, innerException)
        {
            SdkVersion = version;
        }

        public string SdkVersion { get; }
    }
}
