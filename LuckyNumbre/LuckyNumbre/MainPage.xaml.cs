using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LuckyNumbre
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ClickBTN_Clicked(object sender, EventArgs e)
        {
            ClickBTN.text = ReturnRandomNumber().ToString + " is uw geluksgetal!";
        }

        private int ReturnRandomNumber()
        {
            return new Random().Next(10);
        }

    }
}
