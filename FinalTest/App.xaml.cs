using FinalTest.Views;

namespace FinalTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("AppShell Initialized");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}