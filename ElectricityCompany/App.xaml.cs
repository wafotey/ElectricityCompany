using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ElectricityCompany
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDg3MDc2QDMxMzkyZTMyMmUzMFZhaENteHpMempFTWF0a0FnR1JjczdUZ0hvLysrRzZZVmxvcFVERHorb289");
            InitializeComponent();

            MainPage = new ElectricityCompany.MainPage();
            
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
