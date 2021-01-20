using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.CustomControls
{
    public partial class ImageButton : ContentView
    {
        public ImageButton()
        {
            InitializeComponent();

            innerLabel.SetBinding(Label.TextProperty, new Binding("ButtonText", source: this));
            innerImage.SetBinding(Image.SourceProperty, new Binding("Source", source: this));

            this.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => {
                    Clicked?.Invoke(this, EventArgs.Empty);

                    if (Command != null)
                    {
                        if (Command.CanExecute(CommandParameter))
                            Command.Execute(CommandParameter);
                    }
                })
            });
        }

        #region BindableProperty ButtonTextProperty 
        public static readonly BindableProperty ButtonTextProperty =
            BindableProperty.Create("ButtonText", typeof(string), typeof(ImageButton), default(string));

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }
        #endregion BindableProperty ButtonTextProperty 

        #region BindableProperty ImageSourceProperty 
        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create("Source", typeof(ImageSource), typeof(ImageButton), default(ImageSource));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        #endregion BindableProperty ImageSourceProperty

        #region BindableProperty CommandProperty
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create("Command", typeof(ICommand), typeof(ImageButton), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        #endregion BindableProperty CommandProperty

        public event EventHandler Clicked;

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create("CommandParameter", typeof(object), typeof(ImageButton), null);

    }
}
