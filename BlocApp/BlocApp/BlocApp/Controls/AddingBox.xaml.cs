using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlocApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddingBox : StackLayout
    {
        public AddingBox()
        {
            InitializeComponent();

            title.BackgroundColor = BgC;
            label.Text = LabelTxt;
            label.TextColor = LbTxtC;
            label.BackgroundColor = LbBgC;
            DecBbutton.BackgroundColor = BtnBgC;
            IncBbutton.BackgroundColor = BtnBgC;
            entry.Text = EntryTxt;
            DecBbutton.Command = DecCommand;
            IncBbutton.Command = IncCommand;
            DecBbutton.CommandParameter = ComParameter;
            IncBbutton.CommandParameter = ComParameter;

            entry.TextChanged += OnTextChanged;
        }

        public Color BgC
        {
            get { return (Color)GetValue(BgCProperty); }
            set { SetValue(BgCProperty, value); }
        }
        public static readonly BindableProperty BgCProperty = BindableProperty.Create(nameof(BgC), typeof(Color), typeof(AddingBox), default(Color), BindingMode.OneWay);
        public string LabelTxt
        {
            get { return (string)GetValue(LabelTxtProperty); }
            set { SetValue(LabelTxtProperty, value); }
        }
        public static readonly BindableProperty LabelTxtProperty = BindableProperty.Create(nameof(LabelTxt), typeof(string), typeof(AddingBox), default(string), BindingMode.OneWay);

        public Color LbTxtC
        {
            get { return (Color)GetValue(LbTxtCProperty); }
            set { SetValue(LbTxtCProperty, value); }
        }
        public static readonly BindableProperty LbTxtCProperty = BindableProperty.Create(nameof(LbTxtC), typeof(Color), typeof(AddingBox), default(Color), BindingMode.OneWay);

        public Color LbBgC
        {
            get { return (Color)GetValue(LbBgCProperty); }
            set { SetValue(LbBgCProperty, value); }
        }
        public static readonly BindableProperty LbBgCProperty = BindableProperty.Create(nameof(LbBgC), typeof(Color), typeof(AddingBox), default(Color), BindingMode.OneWay);

        public Color BtnBgC
        {
            get { return (Color)GetValue(BtnBgCProperty); }
            set { SetValue(BtnBgCProperty, value); }
        }
        public static readonly BindableProperty BtnBgCProperty = BindableProperty.Create(nameof(BtnBgC), typeof(Color), typeof(AddingBox), default(Color), BindingMode.OneWay);

        public string EntryTxt
        {
            get { return (string)GetValue(EntryTxtProperty); }
            set { SetValue(EntryTxtProperty, value); }
        }
        public static readonly BindableProperty EntryTxtProperty = BindableProperty.Create(nameof(EntryTxt), typeof(string), typeof(AddingBox), default(string), BindingMode.TwoWay);

        public ICommand DecCommand
        {
            get { return (ICommand)GetValue(DecCommandProperty); }
            set { SetValue(DecCommandProperty, value); }
        }
        public static readonly BindableProperty DecCommandProperty = BindableProperty.Create(nameof(DecCommand), typeof(ICommand), typeof(AddingBox), default(ICommand), BindingMode.OneWay);

        public ICommand IncCommand
        {
            get { return (ICommand)GetValue(IncCommandProperty); }
            set { SetValue(IncCommandProperty, value); }
        }
        public static readonly BindableProperty IncCommandProperty = BindableProperty.Create(nameof(IncCommand), typeof(ICommand), typeof(AddingBox), default(ICommand), BindingMode.OneWay);

        public object ComParameter
        {
            get { return GetValue(ComParameterProperty); }
            set { SetValue(ComParameterProperty, value); }
        }
        public static readonly BindableProperty ComParameterProperty = BindableProperty.Create(nameof(ComParameter), typeof(object), typeof(AddingBox), default, BindingMode.OneWay);

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == BgCProperty.PropertyName)
                title.BackgroundColor = BgC;

            else if (propertyName == LabelTxtProperty.PropertyName)
                label.Text = LabelTxt;

            else if (propertyName == LbTxtCProperty.PropertyName)
                label.TextColor = LbTxtC;

            else if (propertyName == LbBgCProperty.PropertyName)
                label.BackgroundColor = LbBgC;

            else if (propertyName == BtnBgCProperty.PropertyName)
            {
                DecBbutton.BackgroundColor = BtnBgC;
                IncBbutton.BackgroundColor = BtnBgC;
            }

            else if (propertyName == EntryTxtProperty.PropertyName)
                entry.Text = EntryTxt;

            else if (propertyName == DecCommandProperty.PropertyName)
                DecBbutton.Command = DecCommand;

            else if (propertyName == IncCommandProperty.PropertyName)
                IncBbutton.Command = IncCommand;

            else if (propertyName == ComParameterProperty.PropertyName)
            {
                DecBbutton.CommandParameter = ComParameter;
                IncBbutton.CommandParameter = ComParameter;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            EntryTxt = e.NewTextValue;
        }
    }
}