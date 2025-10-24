using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_AA.MVVM.VIEWS
{
    public class comandosViewModel
    {
        public ICommand ClickComand { get; } 
        
        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }
        public comandosViewModel()
        {
            ClickComand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("titulo", "mensaje", "Aceptar");

            });

           SearchCommand = new Command((s) =>
           {
              var data = s;
           });

        }

        private void Alert()
        {

        }
    }
}
