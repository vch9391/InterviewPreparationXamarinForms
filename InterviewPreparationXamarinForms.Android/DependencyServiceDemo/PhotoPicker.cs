using System;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using InterviewPreparationXamarinForms.DependencyServiceDemo;
using InterviewPreparationXamarinForms.Droid.DependencyServiceDemo;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhotoPicker))]
namespace InterviewPreparationXamarinForms.Droid.DependencyServiceDemo
{
    public class PhotoPicker : IPhotoPicker
    {
        Context _context;

        public PhotoPicker(Context context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public Task<Stream> GetImageStreamAsync()
        {

            // Define the Intent for getting images
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            var activity = (MainActivity)_context;

            // Start the picture-picker activity (resumes in MainActivity.cs)
            activity.StartActivityForResult(
                Intent.CreateChooser(intent, "Select Photo"),
                MainActivity.PickImageId);

            // Save the TaskCompletionSource object as a MainActivity property
            activity.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            // Return Task object
            return activity.PickImageTaskCompletionSource.Task;
        }
    }
}