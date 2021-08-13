using System.IO;

namespace SystemHR.UserInterface.Helpers
{
    class ResourcesHelper
    {
        public const string CloseButtonName = "close.png";
        public static string ResourcesFilePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"),"Resources");
    }
}
