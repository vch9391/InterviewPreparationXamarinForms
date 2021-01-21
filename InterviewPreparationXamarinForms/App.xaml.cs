using System.Diagnostics;
using InterviewPreparationXamarinForms.Services;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms
{
    public partial class App : Application
    {
        public static string AzureBackendUrl = "http://localhost:5000";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<AzureDataStore>();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("App-OnStart called in XamarinForms App.");
            base.OnStart();
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("App-OnSleep called in XamarinForms App.");
            base.OnSleep();
        }

        protected override void OnResume()
        {
            Debug.WriteLine("App-OnResume called in XamarinForms App.");
            base.OnResume();
        }

    }
}
