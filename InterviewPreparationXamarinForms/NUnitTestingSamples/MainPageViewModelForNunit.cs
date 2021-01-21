using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.NUnitTestingSamples
{
    public class MainPageViewModelForNunit : INotifyPropertyChanged
    {
        IDependencyService DependencyService { get; set; }
        public ICommand SubmitCommand { protected set; get; }
        public ICommand TempSubmitCommand { protected set; get; }

        public MainPageViewModelForNunit() : this(new DependencyServiceWrapper())
        {

        }

        public MainPageViewModelForNunit(IDependencyService dependencyService)
        {
            DependencyService = dependencyService;
            SubmitCommand = new Command(OnSubmit);
            TempSubmitCommand = new Command(TempOnSubmit);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _Entry1;
        public int Entry1
        {
            get { return _Entry1; }
            set
            {
                _Entry1 = value;
                OnPropertyChanged("Entry1");
            }
        }
        private int _Entry2;
        public int Entry2
        {
            get { return _Entry2; }
            set
            {
                _Entry2 = value;
                OnPropertyChanged("Entry2");
            }
        }
        private int _Label1;
        public int Label1
        {
            get { return _Label1; }
            set
            {
                _Label1 = value;
                OnPropertyChanged("Label1");
            }
        }


        public void OnSubmit()
        {
            Console.WriteLine("OnSubmit");
            var service = DependencyService.Get<ICalculateServer>();
            if (service == null)
            {
                Console.WriteLine("service==null");
                return;
            }

            Console.WriteLine(Entry1);
            Console.WriteLine(Entry2);

            try
            {
                Label1 = (int)(service?.Add(Entry1, Entry2));
                Console.WriteLine(Label1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return;
        }

        private int _TempTesting;
        public int TempTesting
        {
            get { return _TempTesting; }
            set
            {
                _TempTesting = value;
                OnPropertyChanged("_TempTesting");
            }
        }

        public void TempOnSubmit()
        {
            TempTesting = 10;
        }
    }
}
