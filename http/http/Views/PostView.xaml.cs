using http.ViewModels;

namespace http.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new PostViewModel();
	}
}