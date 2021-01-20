using System;
using System.Collections.Generic;
using InterviewPreparationXamarinForms.ViewModels;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class DataBindingTypesPage : ContentPage
    {
        public DataBindingTypesPage()
        {
            BindingContext = new DataBindingTypesViewModel();

            InitializeComponent();
        }
    }
}
