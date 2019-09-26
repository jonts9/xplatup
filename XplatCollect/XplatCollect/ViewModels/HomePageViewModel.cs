using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XplatCollect.ViewModels
{
    public sealed class HomePageViewModel : ViewModelBase
    {
        private string title;

        private string collectionName;
        public string CollectionName { get=>collectionName; set=>SetProperty(ref collectionName, value); }

        public HomePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            ViewCollectionCommand = new DelegateCommand(async () => await ExecuteViewCollectionCommand());
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public ICommand ViewCollectionCommand { get; set; }

        private async Task ExecuteViewCollectionCommand()
        {
            await Task.CompletedTask;
        }
    }
}