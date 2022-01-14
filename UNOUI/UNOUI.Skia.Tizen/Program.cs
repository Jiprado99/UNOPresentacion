using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UNOUI.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UNOUI.App(), args);
            host.Run();
        }
    }
}
