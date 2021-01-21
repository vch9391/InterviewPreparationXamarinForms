using System;
using System.Collections.Generic;
using InterviewPreparationXamarinForms.NUnitTestingSamples;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class nUnitMainPage : ContentPage
    {
        public nUnitMainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModelForNunit();
        }
    }
}
