using System;
using InterviewPreparationXamarinForms.DependencyServiceDemo;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class PhotoPickerPage : ContentPage
    {
        public PhotoPickerPage()
        {
            InitializeComponent();
        }

        async void OnSelectPhotoButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.IsEnabled = false;

            var photoPickerService = DependencyService.Resolve<IPhotoPicker>();
            var stream = await photoPickerService.GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

            button.IsEnabled = true;
        }
    }
}
