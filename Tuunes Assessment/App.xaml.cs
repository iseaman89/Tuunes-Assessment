using Tuunes_Assessment.ViewModels;

namespace Tuunes_Assessment;

public partial class App : Application
{
	public App(ListenViewModel listenViewModel)
	{
		InitializeComponent();

		MainPage = new AppShell(listenViewModel);
	}
}