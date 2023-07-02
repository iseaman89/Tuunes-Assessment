using Tuunes_Assessment.Models;
using Tuunes_Assessment.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Tuunes_Assessment.ViewModels
{
	[QueryProperty(nameof(Rington), nameof(Rington))]
	public partial class DetailViewModel : BaseViewModel
	{
		[ObservableProperty]
		private Rington _rington;

		public DetailViewModel(INavigationService navigationService) : base(navigationService) { }

		[RelayCommand]
		public async void GoBackAsync() => await NavigationService.NavigateBackAsync();
	}
}