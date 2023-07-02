using Tuunes_Assessment.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Tuunes_Assessment.ViewModels
{
	public class BaseViewModel : ObservableObject
	{
		protected INavigationService NavigationService;

		public BaseViewModel(INavigationService navigationService)
		{
			NavigationService = navigationService;
		}
	}
}