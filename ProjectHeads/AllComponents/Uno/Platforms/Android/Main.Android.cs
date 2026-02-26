using Android.App;
using Android.Runtime;

namespace CommunityToolkit.App.Uno;

[global::Android.App.ApplicationAttribute(
    Label = "@string/ApplicationName",
    Icon = "@mipmap/icon",
    LargeHeap = true,
    HardwareAccelerated = true,
    Theme = "@style/AppTheme"
)]
public class Application : Microsoft.UI.Xaml.NativeApplication
{
    public Application(IntPtr javaReference, JniHandleOwnership transfer)
        : base(() => new CommunityToolkit.App.Shared.App(), javaReference, transfer)
    {
    }
}
