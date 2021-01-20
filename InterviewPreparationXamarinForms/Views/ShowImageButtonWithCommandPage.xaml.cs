using System;
using System.Collections.Generic;
using InterviewPreparationXamarinForms.ViewModels;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class ShowImageButtonWithCommandPage : ContentPage
    {
        public ShowImageButtonWithCommandPage()
        {
            BindingContext = new ShowImageButtonWithCommandViewModels();

            InitializeComponent();
        }
    }
}
