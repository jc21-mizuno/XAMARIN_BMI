using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBMI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{
        private float height;
        private int weight;

        public BmiResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
        }

        public BmiResult(float height, int weight)
        {

            InitializeComponent();
            this.height = height;
            this.weight = weight;
            labelBMI.Text = "BMI: " + weight / height / height;
            buttonBack.Clicked += buttonBackClicked;
        }
        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}