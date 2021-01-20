using Android.Content;
using Android.Runtime;
using Android.Views;
using InterviewPreparationXamarinForms.DependencyServiceDemo;
using InterviewPreparationXamarinForms.Droid.DependencyServiceDemo;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace InterviewPreparationXamarinForms.Droid.DependencyServiceDemo
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;

            bool isLandscape =
                orientation == SurfaceOrientation.Rotation90 ||
                orientation == SurfaceOrientation.Rotation270;

            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}
