using Tuunes_Assessment.ViewModels;

namespace Tuunes_Assessment.Views;

public partial class ListenPage : ContentPage
{
	public ListenPage(ListenViewModel listenViewModel)
	{
		InitializeComponent();

		BindingContext = listenViewModel;
	}
}