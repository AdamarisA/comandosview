using MVVM_AA.MVVM.ViewModels;

namespace MVVM_AA.MVVM.VIEWS;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new personViewModel();
    }
}