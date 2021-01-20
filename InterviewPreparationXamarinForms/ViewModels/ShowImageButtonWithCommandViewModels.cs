using System;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.ViewModels
{
    public class ShowImageButtonWithCommandViewModels : BaseViewModel
    {
        public ShowImageButtonWithCommandViewModels() : base("")
        {
        }

        string statusMessage = "";
        public string StatusMessage
        {
            get { return statusMessage; }
            set { statusMessage = value; OnPropertyChanged(); }
        }

        #region MyCommand
        Command myCmd;
        public Command MyCommand => myCmd ?? (myCmd = new Command(() => ExecuteMyCommand()));

        void ExecuteMyCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                StatusMessage = "You have activated the command!";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Login] Error = {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion MyCommand
    }
}
