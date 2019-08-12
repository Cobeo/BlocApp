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
            //BlocListView.ItemsSource = App.BlocDB.GetAllAsync().Result;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //BlocListView.ItemsSource = App.BlocDB.GetAllAsync().Result;
        }

        private void ButtonListView_Clicked(object sender, EventArgs e)
        {
            CtrlTmplate.ControlTemplate = (ControlTemplate)Resources["BlocList"];
        }

        private void ButtonCalendarView_Clicked(object sender, EventArgs e)
        {
            CtrlTmplate.ControlTemplate = (ControlTemplate)Resources["BlocCalendar"];
        }
    }
}