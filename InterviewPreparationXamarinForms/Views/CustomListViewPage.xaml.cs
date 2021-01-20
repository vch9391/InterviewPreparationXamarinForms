using System;
using System.Collections.Generic;
using InterviewPreparationXamarinForms.ViewModels;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class CustomListViewPage : ContentPage
    {
        public CustomListViewPage()
        {
            InitializeComponent();
            BindingContext = new CustomListViewViewModel();
        }
    }
}
