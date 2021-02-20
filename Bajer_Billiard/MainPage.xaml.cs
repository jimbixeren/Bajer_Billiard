using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bajer_Billiard.Players;


namespace Bajer_Billiard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);

            iconImage.Source = ImageSource.FromResource("Bajer_Billiard.Assets.Images.DeadPool.png", assembly);

          
            

        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
