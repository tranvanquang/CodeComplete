using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BTVN_C3.Views;
namespace BTVN_C3
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
            Navigation.PushAsync(new StackLayoutHorizontal());
        }
        private void HandleChoice2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutVertical());
        }
        private void HandleChoice3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutExample());
        }
        private void HandleChoice4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutExample());
        }
        private void HandleChoice5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridExample1());
        }
        private void HandleChoice6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridExample2());
        }
        private void HandleChoice7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridExample3());
        }
        private void HandleChoice8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentViewExample());
        }
        private void HandleChoice9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FrameExample());
        }
    }
}
