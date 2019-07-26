using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlocApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlocListPage : ContentPage
    {
        public BlocListPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BlocListView.ItemsSource = App.BlocDB.GetAllAsync().Result;
        }
    }
}