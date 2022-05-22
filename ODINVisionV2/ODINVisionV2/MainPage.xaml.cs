using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ODINVisionV2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var url = URL.Text;
            var station = Station.Text;

            var answer = await DisplayAlert("Confirm", $"{url}/?stationid={station}", "Confirm", "Cancel");

            if (answer)
            {
                await Navigation.PushAsync(new SequenceView(url, station));
            }
          
        }
    }
}

