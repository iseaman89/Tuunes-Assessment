using System.Collections.ObjectModel;
using System.Net;
using Tuunes_Assessment.Models;
using Tuunes_Assessment.Views;
using Tuunes_Assessment.Services;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Tuunes_Assessment.ViewModels
{
	public partial class ListenViewModel : BaseViewModel
	{
		private readonly string _dataUrl = "https://dl.dropboxusercontent.com/s/3uw4duo7hyue7ld/Ringtones.json?dl=0";

		public ObservableCollection<Rington> Ringtons { get; set; } = new();

		public ListenViewModel(INavigationService navigationService) : base(navigationService)
		{
            _ = GetRingtonesAsync();
		}

		[RelayCommand]
		public async void GoToDetail(Rington rington)
		{
			if (rington is null) return;

			await NavigationService.NavigateToAsync(nameof(DetailPage),
				new Dictionary<string, object> { { nameof(Rington), rington } });
		}

		public async Task GetRingtonesAsync()
		{
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
#if ANDROID

                await Toast.Make("No internet!", ToastDuration.Short).Show();

#else

                await Application.Current.MainPage.DisplayAlert("Warning", "No internet!", "Ok");

#endif

            try
			{
				WebClient webClient = new();
				var json = webClient.DownloadString(_dataUrl);

                Ringtons = JsonConvert.DeserializeObject<ObservableCollection<Rington>>(json);
			}
			catch (Exception)
			{
#if ANDROID

				await Toast.Make("Ups! Something wrong!", ToastDuration.Short).Show();

#else

                await Application.Current.MainPage.DisplayAlert("Warning", "Ups! Something wrong!", "Ok");

#endif
            }
        }
	}
}