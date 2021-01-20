using InterviewPreparationXamarinForms.DependencyServiceDemo;
using InterviewPreparationXamarinForms.iOS.DependencyServiceDemo;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace InterviewPreparationXamarinForms.iOS.DependencyServiceDemo
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait =
                orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;

            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}
