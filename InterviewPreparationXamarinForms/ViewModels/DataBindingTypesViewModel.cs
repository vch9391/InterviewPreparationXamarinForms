using System;
namespace InterviewPreparationXamarinForms.ViewModels
{
    public class DataBindingTypesViewModel : BaseViewModel
    {
        string _OneTimeBindingProperty = "OneTime";
        public string OneTimeBindingProperty
        {
            get { return _OneTimeBindingProperty; }
            set { _OneTimeBindingProperty = value; OnPropertyChanged(); }
        }

        string _OneWayBindingProperty;
        public string OneWayBindingProperty
        {
            get { return _OneWayBindingProperty; }
            set { _OneWayBindingProperty = value; OnPropertyChanged(); }
        }

        string _OneWayToSourceBindingProperty;
        public string OneWayToSourceBindingProperty
        {
            get { return _OneWayToSourceBindingProperty; }
            set { _OneWayToSourceBindingProperty = value; OnPropertyChanged(); }
        }

        string _TwoWayBindingProperty;
        public string TwoWayBindingProperty
        {
            get { return _TwoWayBindingProperty; }
            set { _TwoWayBindingProperty = value; OnPropertyChanged(); }
        }
    }
}
