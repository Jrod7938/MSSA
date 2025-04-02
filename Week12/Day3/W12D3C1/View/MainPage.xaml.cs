using W12D3C1.ViewModel;

namespace W12D3C1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MonkeysViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
