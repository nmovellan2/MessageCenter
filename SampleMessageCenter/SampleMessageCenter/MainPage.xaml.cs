using SampleMessageCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleMessageCenter
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //subscribirse a un evento
            MessagingCenter.Subscribe<MainViewModel>(this, "LimitAge", (vm) => {
                DisplayAlert("Error", "Age avereached", "Cancel");
            });

        }
    }
}
