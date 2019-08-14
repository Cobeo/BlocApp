using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using BlocApp.Views;
using System.Linq;
using BlocApp.Models;

namespace BlocApp.ViewModels
{
    public class AddBlocViewModel : BaseViewModel
    {
        #region Constructor

        public AddBlocViewModel()
        {
            SaveCommand = new Command(_saveCommand);

            ResetCommand = new Command(_resetCommand);

            IncreaseCommand = new Command<string>(_increase);
            DecreaseCommand = new Command<string>(_decrease);
        }

        #endregion Constructor

        #region Parameters
        public string[] VerminOuFrancais { get; } = new string[] { "Vermin", "Français" };
        public bool IsVermin
        {
            get => _isVermin;
            set
            {
                if (_isVermin == value)
                    return;

                _isVermin = value;
                OnPropertyChanged(nameof(IsVermin));
                OnPropertyChanged(nameof(DisplayV0));
                OnPropertyChanged(nameof(DisplayV1));
                OnPropertyChanged(nameof(DisplayV2));
                OnPropertyChanged(nameof(DisplayV3));
                OnPropertyChanged(nameof(DisplayV4));
                OnPropertyChanged(nameof(DisplayV5));
                OnPropertyChanged(nameof(DisplayV6));
                OnPropertyChanged(nameof(DisplayV7));
                OnPropertyChanged(nameof(DisplayV8));
                OnPropertyChanged(nameof(DisplayV9));
            }
        }
        private bool _isVermin = true;
        
        public int V0
        {
            get => _v0;
            set
            {
                if (_v0 == value)
                    return;

                _v0 = value;
                OnPropertyChanged(nameof(V0));
            }
        }
        private int _v0 = 0;

        public int V1
        {
            get => _v1;
            set
            {
                if (_v1 == value)
                    return;

                _v1 = value;
                OnPropertyChanged(nameof(V1));
            }
        }
        private int _v1 = 0;

        public int V2
        {
            get => _v2;
            set
            {
                if (_v2 == value)
                    return;

                _v2 = value;
                OnPropertyChanged(nameof(V2));
            }
        }
        private int _v2 = 0;

        public int V3
        {
            get => _v3;
            set
            {
                if (_v3 == value)
                    return;

                _v3 = value;
                OnPropertyChanged(nameof(V3));
            }
        }
        private int _v3 = 0;

        public int V4
        {
            get => _v4;
            set
            {
                if (_v4 == value)
                    return;

                _v4 = value;
                OnPropertyChanged(nameof(V4));
            }
        }
        private int _v4 = 0;

        public int V5
        {
            get => _v5;
            set
            {
                if (_v5 == value)
                    return;

                _v5 = value;
                OnPropertyChanged(nameof(V5));
            }
        }
        private int _v5 = 0;

        public int V6
        {
            get => _v6;
            set
            {
                if (_v6 == value)
                    return;

                _v6 = value;
                OnPropertyChanged(nameof(V6));
            }
        }
        private int _v6 = 0;

        public int V7
        {
            get => _v7;
            set
            {
                if (_v7 == value)
                    return;

                _v7 = value;
                OnPropertyChanged(nameof(V7));
            }
        }
        private int _v7 = 0;

        public int V8
        {
            get => _v8;
            set
            {
                if (_v8 == value)
                    return;

                _v8 = value;
                OnPropertyChanged(nameof(V8));
            }
        }
        private int _v8 = 0;

        public int V9
        {
            get => _v9;
            set
            {
                if (_v9 == value)
                    return;

                _v9 = value;
                OnPropertyChanged(nameof(V9));
            }
        }
        private int _v9 = 0;

        public string DisplayV0
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(1).Result.Vermin;
                return App.CotationDB.GetAsync(1).Result.Francais;
            }
        }
        public string DisplayV1
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(2).Result.Vermin;
                return App.CotationDB.GetAsync(2).Result.Francais;
            }
        }
        public string DisplayV2
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(3).Result.Vermin;
                return App.CotationDB.GetAsync(3).Result.Francais;
            }
        }
        public string DisplayV3
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(4).Result.Vermin;
                return App.CotationDB.GetAsync(4).Result.Francais;
            }
        }
        public string DisplayV4
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(5).Result.Vermin;
                return App.CotationDB.GetAsync(5).Result.Francais;
            }
        }
        public string DisplayV5
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(6).Result.Vermin;
                return App.CotationDB.GetAsync(6).Result.Francais;
            }
        }
        public string DisplayV6
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(7).Result.Vermin;
                return App.CotationDB.GetAsync(7).Result.Francais;
            }
        }
        public string DisplayV7
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(8).Result.Vermin;
                return App.CotationDB.GetAsync(8).Result.Francais;
            }
        }
        public string DisplayV8
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(9).Result.Vermin;
                return App.CotationDB.GetAsync(9).Result.Francais;
            }
        }
        public string DisplayV9
        {
            get
            {
                if (IsVermin)
                    return App.CotationDB.GetAsync(10).Result.Vermin;
                return App.CotationDB.GetAsync(10).Result.Francais;
            }
        }

        #endregion Parameters

        #region Command

        public ICommand SaveCommand { get; }
        private void _saveCommand()
        {
            List<Bloc> newBlocs = new List<Bloc>();
            if (V0 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 1,
                    Location = "BlocShop",
                    NumberDone = V0,
                    NumberFlashed = 0
                });
                V0 = 0;
            }

            if (V1 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 2,
                    Location = "BlocShop",
                    NumberDone = V1,
                    NumberFlashed = 0
                });
                V1 = 0;
            }

            if (V2 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 3,
                    Location = "BlocShop",
                    NumberDone = V2,
                    NumberFlashed = 0
                });
                V2 = 0;
            }

            if (V3 != 0)
            {
                newBlocs.Add(new Models.Bloc()
            {
                AcheivedDate = DateTime.Now,
                IDCotation = 4,
                Location = "BlocShop",
                NumberDone = V3,
                NumberFlashed = 0
            });
                V3 = 0;
            }

            if (V4 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 5,
                    Location = "BlocShop",
                    NumberDone = V4,
                    NumberFlashed = 0
                });
                V4 = 0;
            }

            if (V5 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 6,
                    Location = "BlocShop",
                    NumberDone = V5,
                    NumberFlashed = 0
                });
                V5 = 0;
            }

            if (V6 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 7,
                    Location = "BlocShop",
                    NumberDone = V6,
                    NumberFlashed = 0
                });
                V6 = 0;
            }

            if (V7 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 8,
                    Location = "BlocShop",
                    NumberDone = V7,
                    NumberFlashed = 0
                });
                V7 = 0;
            }

            if (V8 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 9,
                    Location = "BlocShop",
                    NumberDone = V8,
                    NumberFlashed = 0
                });
                V8 = 0;
            }

            if (V9 != 0)
            {
                newBlocs.Add(new Models.Bloc()
                {
                    AcheivedDate = DateTime.Now,
                    IDCotation = 10,
                    Location = "BlocShop",
                    NumberDone = V9,
                    NumberFlashed = 0
                });
                V9 = 0;
            }

            if (newBlocs.Any())
            {
                App.BlocDB.SaveAllAsync(newBlocs);
                OnPropertyChanged(nameof(App.BlocDB));
                App.IsDBModified = true;
            }
        }

        public ICommand ResetCommand { get; }
        public void _resetCommand()
        {
            App.BlocDB.DeleteAllAsync();
            App.IsDBModified = true;
        }
        
        public ICommand IncreaseCommand { get; }
        private void _increase(string cot)
        {
            switch (cot)
            {
                case "V0":
                    V0++;
                    break;
                case "V1":
                    V1++;
                    break;
                case "V2":
                    V2++;
                    break;
                case "V3":
                    V3++;
                    break;
                case "V4":
                    V4++;
                    break;
                case "V5":
                    V5++;
                    break;
                case "V6":
                    V6++;
                    break;
                case "V7":
                    V7++;
                    break;
                case "V8":
                    V8++;
                    break;
                case "V9":
                    V9++;
                    break;
                default:
                    break;
            }
        }

        public ICommand DecreaseCommand { get; }
        private void _decrease(string cot)
        {
            switch (cot)
            {
                case "V0":
                    if (V0 > 0) V0--;
                    break;
                case "V1":
                    if (V1 > 0) V1--;
                    break;
                case "V2":
                    if (V2 > 0) V2--;
                    break;
                case "V3":
                    if (V3 > 0) V3--;
                    break;
                case "V4":
                    if (V4 > 0) V4--;
                    break;
                case "V5":
                    if (V5 > 0) V5--;
                    break;
                case "V6":
                    if (V6 > 0) V6--;
                    break;
                case "V7":
                    if (V7 > 0) V7--;
                    break;
                case "V8":
                    if (V8 > 0) V8--;
                    break;
                case "V9":
                    if (V9 > 0) V9--;
                    break;
                default:
                    break;
            }
        }

        public string IsVerminSelected
        {
            set
            {
                switch (value)
                {
                    case "Vermin":
                        IsVermin = true;
                        break;
                    case "Français":
                        IsVermin = false;
                        break;
                    default:
                        break;
                }

                OnPropertyChanged(nameof(IsVerminSelected));
            }
        }
        #endregion Command
    }
}
