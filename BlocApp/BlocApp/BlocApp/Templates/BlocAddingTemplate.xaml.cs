using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlocApp.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlocAddingTemplate : ContentPresenter
    {
        public BlocAddingTemplate()
        {
            InitializeComponent();
        }

        public string BgC
        {
            get { return (string)GetValue(BgCProperty); }
            set { SetValue(BgCProperty, value); }
        }
        public static readonly BindableProperty BgCProperty = BindableProperty.Create(nameof(BgC), typeof(string), typeof(BlocAddingTemplate), "");

        public string LabelTxt
        {
            get { return (string)GetValue(LabelTxtProperty); }
            set { SetValue(LabelTxtProperty, value); }
        }
        public static readonly BindableProperty LabelTxtProperty = BindableProperty.Create(nameof(LabelTxt), typeof(string), typeof(BlocAddingTemplate), "");

        public string LbTxtC
        {
            get { return (string)GetValue(LbTxtCProperty); }
            set { SetValue(LbTxtCProperty, value); }
        }
        public static readonly BindableProperty LbTxtCProperty = BindableProperty.Create(nameof(LbTxtC), typeof(string), typeof(BlocAddingTemplate), "");

        public string LbBgC
        {
            get { return (string)GetValue(LbBgCProperty); }
            set { SetValue(LbBgCProperty, value); }
        }
        public static readonly BindableProperty LbBgCProperty = BindableProperty.Create(nameof(LbBgC), typeof(string), typeof(BlocAddingTemplate), "");

        public string BtnBgC
        {
            get { return (string)GetValue(BtnBgCProperty); }
            set { SetValue(BtnBgCProperty, value); }
        }
        public static readonly BindableProperty BtnBgCProperty = BindableProperty.Create(nameof(BtnBgC), typeof(string), typeof(BlocAddingTemplate), "");

        public string EntryTxt
        {
            get { return (string)GetValue(EntryTxtProperty); }
            set { SetValue(EntryTxtProperty, value); }
        }
        public static readonly BindableProperty EntryTxtProperty = BindableProperty.Create(nameof(EntryTxt), typeof(string), typeof(BlocAddingTemplate), "");

        public string DecCommand
        {
            get { return (string)GetValue(DecCommandProperty); }
            set { SetValue(DecCommandProperty, value); }
        }
        public static readonly BindableProperty DecCommandProperty = BindableProperty.Create(nameof(DecCommand), typeof(string), typeof(BlocAddingTemplate), "");

        public string IncCommand
        {
            get { return (string)GetValue(IncCommandProperty); }
            set { SetValue(IncCommandProperty, value); }
        }
        public static readonly BindableProperty IncCommandProperty = BindableProperty.Create(nameof(IncCommand), typeof(string), typeof(BlocAddingTemplate), "");

        public string ComParameter
        {
            get { return (string)GetValue(ComParameterProperty); }
            set { SetValue(ComParameterProperty, value); }
        }
        public static readonly BindableProperty ComParameterProperty = BindableProperty.Create(nameof(ComParameter), typeof(string), typeof(BlocAddingTemplate), "");
    }
}