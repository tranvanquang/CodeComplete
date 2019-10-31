using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BTVN_C4.Views;
namespace BTVN_C4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void HandleChoice1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedbackPage());
        }
        private void HandleChoice2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocalDesignPage());
        }
        private void HandleChoice3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaticResourcesPage());
        }
        private void HandleChoice4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicResourcePage());
        }
        private void HandleChoice5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImportResourcesPage());
        }
        private void HandleChoice6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExplicitStylePage());
        }
        private void HandleChoice7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImplicitStylePage());
        }
        private void HandleChoice8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverridingStylesPage());
        }
        private void HandleChoice9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithStaticInheritancePage());
        }
        private void HandleChoice10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithDynamicInheritancePage());
        }
        private void HandleChoice11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StylesPage());
        }
        private void HandleChoice12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LightThemePage());
        }
        private void HandleChoice13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DarkThemePage());
        }
        private void HandleChoice14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceStylePage());
        }
        private void HandleChoice15(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomDarkThemePage());
        }
    }
}
