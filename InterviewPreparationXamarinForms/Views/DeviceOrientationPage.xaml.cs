using System;
using System.IO;
using InterviewPreparationXamarinForms.DependencyServiceDemo;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class DeviceOrientationPage : ContentPage
    {
        public DeviceOrientationPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            orientationLabel.Text = orientation.ToString();
        }
    }
}
