using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace BlocApp.ViewModels
{
    public class BlocListViewModel : BaseViewModel
    {
        #region Constructor

        public BlocListViewModel()
        {
        }

        #endregion Constructor

        #region Parameters
        public string Place { get; } = "BlocShop";
        public ObservableCollection<NombreVoie> nombreVoie
        { 
            get
            {
                List<Models.Bloc> tmpBloc = App.BlocDB.GetAllAsync().Result;
                return new ObservableCollection<NombreVoie>
                {
                    new NombreVoie
                    {
                        Nom = "Total",
                        Fait = tmpBloc.Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(1).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 1).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 1).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(2).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 2).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 2).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(3).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 3).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 3).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(4).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 4).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 4).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(5).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 5).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 5).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(6).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 6).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 6).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(7).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 7).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 7).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(8).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 8).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 8).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(9).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 9).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 9).Select(n => n.NumberFlashed).Sum()
                    },
                    new NombreVoie
                    {
                        Nom = App.CotationDB.GetAsync(10).Result.Vermin,
                        Fait = tmpBloc.Where(x => x.IDCotation == 10).Select(n => n.NumberDone).Sum(),
                        Flash = tmpBloc.Where(x => x.IDCotation == 10).Select(n => n.NumberFlashed).Sum()
                    }
                };
            }
        }
        #endregion Parameters

        #region Command

        #endregion Command

        #region Event

        #endregion Event

        #region Class
        public class NombreVoie
        {
            public string Nom { get; set; }
            public int Fait { get; set; }
            public int Flash { get; set; }
        }
        #endregion Class
    }

}
