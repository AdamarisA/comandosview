using MVVM_AA.MVVM.ViewModels;

namespace MVVM_AA.MVVM.VIEWS;

public partial class GenteviewsModel : ContentPage
{
	public GenteviewsModel()
	{
		InitializeComponent();

        BindingContext = new GenteviewModel();
    }
}