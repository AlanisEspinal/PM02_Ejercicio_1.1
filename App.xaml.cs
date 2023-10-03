namespace PM02_Ejercicio_1._1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override void OnStart()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}