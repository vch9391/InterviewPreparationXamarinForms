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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
