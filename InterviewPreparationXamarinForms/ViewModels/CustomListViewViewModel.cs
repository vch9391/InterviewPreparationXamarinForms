using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.ViewModels
{
    public class CustomListViewViewModel : BaseViewModel
    {
        public CustomListViewViewModel()
        {
            Title = "Task List";
            Items = new ObservableCollection<string>();
            AddItems();
        }

        ObservableCollection<string> items = new ObservableCollection<string>();
        public ObservableCollection<string> Items
        {
            get { return items; }
            set { SetProperty(ref items, value, "Items"); }
        }

        int countCheck = 0;

        Command addNewCmd;
        public Command LoadMoreCommandTemp => addNewCmd ?? (addNewCmd = new Command(async () => await ExecuteAddNewItemCommand()));

        async Task ExecuteAddNewItemCommand()
        {
            if (IsBusy || countCheck == 3)
                return;
            IsBusy = true;

            try
            {
                await Task.Delay(3000);
                Items.Add(DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[TaskList] Error in AddNewItem: {ex.Message}");
            }
            finally
            {
                IsBusy = false;
                countCheck++;
            }
        }

        private void AddItems()
        {
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2021 3:55:12 PM");
            Items.Add("1/19/2020 3:55:12 PM");
        }
    }
}
