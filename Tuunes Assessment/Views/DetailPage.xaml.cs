using CommunityToolkit.Maui.Core.Primitives;
using Tuunes_Assessment.ViewModels;

namespace Tuunes_Assessment.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel detailViewModel)
	{
		InitializeComponent();

		BindingContext = detailViewModel;
	}

    #region MediaElement

    private void PlayPauseSoundButton(Object sender, EventArgs e)
    {
        var button = sender as ImageButton;

        if (mediaElement.CurrentState == MediaElementState.Paused)
            button.Source = "pause.svg";
        else if (mediaElement.CurrentState == MediaElementState.Playing)
            button.Source = "play.svg";

        if (mediaElement.CurrentState == MediaElementState.Stopped ||
            mediaElement.CurrentState == MediaElementState.Paused)
            mediaElement.Play();
        else if (mediaElement.CurrentState == MediaElementState.Playing)
            mediaElement.Pause();
    }

    private void DetailPageUnloaded(Object sender, EventArgs e) =>
         mediaElement.Handler?.DisconnectHandler();

    private void OnMediaEnded(Object sender, EventArgs e)
    {
        mediaElement.Stop();
        playPauseButton.Source = "play.svg";
    }

    #endregion
}