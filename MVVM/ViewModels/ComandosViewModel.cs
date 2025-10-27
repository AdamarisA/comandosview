
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_AA.MVVM.ViewModels
{
    internal class ComandosViewModel
    {

        public ICommand ClickComand { get; }

        public ComandosViewModel()
        {
            ClickComand = new Command(() =>
            {
             App.Current.MainPage.DisplayAlert("Titulo", "Mensaje", "Aceptar");



            });

        }
    private void Alert()
    {


    }
    }




}
