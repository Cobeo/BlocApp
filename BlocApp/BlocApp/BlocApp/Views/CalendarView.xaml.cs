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
    public partial class CalendarView : Grid
    {
        public CalendarView()
        {
            InitializeComponent();
        }

        public bool istrue()
        {
            return true;
        }
    }
}