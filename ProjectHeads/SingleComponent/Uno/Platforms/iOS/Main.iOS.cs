using Uno.UI.Hosting;
using CommunityToolkit.App.Shared;

namespace CommunityToolkit.App.Uno;

public class EntryPoint
{
    public static void Main(string[] args)
    {
        var host = UnoPlatformHostBuilder.Create()
            .App(() => new CommunityToolkit.App.Shared.App())
            .UseAppleUIKit()
            .Build();

        host.Run();
    }
}
