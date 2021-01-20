using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPreparationXamarinForms.Views;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void items_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            switch (e.Item.ToString())
            {
                case "Custom Control - Image Button":
                    Navigation.PushAsync(new ShowImageButtonWithCommandPage());
                    break;
                case "Custom Control - Gauge":
                    Navigation.PushAsync(new DisplayGaugePage());
                    break;
                case "Dependency Service - Device Orientation":
                    Navigation.PushAsync(new DeviceOrientationPage());
                    break;
                case "Dependency Service - Photo Picker Page":
                    Navigation.PushAsync(new PhotoPickerPage());
                    break;
                case "Data Binding Types":
                    Navigation.PushAsync(new DataBindingTypesPage());
                    break;
                case "Custom Renderer Page with Trigger":
                    Navigation.PushAsync(new CustomRendererPage());
                    break;
                case "Platform Effects":
                    Navigation.PushAsync(new PlatformEffectsPage());
                    break;
                case "Custom List View":
                    Navigation.PushAsync(new CustomListViewPage());
                    break;

            }
        }
    }
}
