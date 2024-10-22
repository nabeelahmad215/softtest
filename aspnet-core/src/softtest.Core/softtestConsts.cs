using softtest.Debugging;

namespace softtest
{
    public class softtestConsts
    {
        public const string LocalizationSourceName = "softtest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "045c87221f6e49749ee01e3820ba0e92";
    }
}
