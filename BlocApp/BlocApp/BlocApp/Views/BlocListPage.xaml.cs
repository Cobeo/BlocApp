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

            if (App.IsDBModified)
            {
                //((ListView)((Grid)CtrlTmplate.Children[0]).Children[4]).BeginRefresh();

                App.IsDBModified = false;
            }
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