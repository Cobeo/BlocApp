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

            if (newBlocs.Any())
                App.BlocDB.SaveAllAsync(newBlocs);
        }

        public ICommand ResetCommand { get; }
        public void _resetCommand() { V0 = 0; V1 = 0; V2 = 0; V3 = 0; V4 = 0; V5 = 0; }
        
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
                default:
                    break;
            }
        }

        #endregion Command
    }
}
