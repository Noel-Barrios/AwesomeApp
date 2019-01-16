using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AwesomeApp
{
    // to maximize reuse of the startup code, Xamarin.Forms applications have a single class named App
    // that is responsible for instantiating the first Page that will be displayed.
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //sets the App.MainPage property to an instance of the MainPage class
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
