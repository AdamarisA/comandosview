using MVVM_AA.MVVM.ViewModels;
using System.Windows.Input;

namespace MVVM_AA.MVVM.VIEWS;

public partial class comandosView : ContentPage
{
    public comandosView()
    {
        InitializeComponent();

        BindingContext = new ComandosViewModel();
    }

}