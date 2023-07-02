using Tuunes_Assessment.ViewModels;
using Tuunes_Assessment.Views;

namespace Tuunes_Assessment;

public partial class AppShell : Shell
{
    private ListenViewModel _listenViewModel;

    public AppShell(ListenViewModel listenViewModel)
	{
		InitializeComponent();

		_listenViewModel = listenViewModel;

		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}