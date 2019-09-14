using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XplatCollect.ViewModels
{
    public sealed class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            
        }

        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}