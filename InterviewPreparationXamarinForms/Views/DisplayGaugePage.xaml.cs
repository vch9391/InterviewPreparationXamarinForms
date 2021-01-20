﻿using InterviewPreparationXamarinForms.CustomControls;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.Views
{
    public partial class DisplayGaugePage : ContentPage
    {
        SimpleGauge gauge;

        public DisplayGaugePage()
        {

            Title = "Speed Gauge";

            var layout = new StackLayout();

            gauge = new SimpleGauge()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HighlightRangeStartValue = 0,
                HighlightRangeEndValue = 30,
                Value = 88f,
                UnitsText = "mph",
                WidthRequest = 500,
                HeightRequest = 500
            };

            var slideValue = new Slider()
            {
                Minimum = 0,
                Maximum = 100,
                Value = 88
            };

            slideValue.ValueChanged += (sender, e) => {
                gauge.Value = (float)slideValue.Value;
            };

            layout.Children.Add(slideValue);
            layout.Children.Add(gauge);

            Content = layout;

            InitializeComponent();
        }
    }
}
