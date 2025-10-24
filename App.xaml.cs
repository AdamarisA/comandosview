using MVVM_AA.MVVM.VIEWS;

namespace MVVM_AA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new comandosView();
        }
    }
    
}
