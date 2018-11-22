using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            ButtonBMI.Clicked += ButtonBMIClickEvent;
            ButtonBMI2.Clicked += ButtonBMIClickEvent2;
        }

        private void ButtonBMIClickEvent(object sender, EventArgs e)
        {

            try
            {
                //throw new NotImplementedException();
                float height = float.Parse(EntryHeight.Text);
                int weight = int.Parse(EntryWeight.Text);

                if (height > 2.72)
                {
                    height = height / 100;
                }

                LabelResult.Text = "BMI: " + weight / height / height;

            }
            catch
            {
                LabelResult.Text = "数値を正しく入力してください";
            }
        }
        
        private void ButtonBMIClickEvent2(object sender, EventArgs e)
        {
            try
            {
                float height = float.Parse(EntryHeight.Text);
                int weight = int.Parse(EntryWeight.Text);

                if (height > 2.72)
                {
                    height = height / 100;
                }
                Navigation.PushModalAsync(new NavigationPage(new BmiResult(height, weight)));
            }
            catch
            {
                LabelResult.Text = "数値を正しく入力してください";
            }
        }
        
    }
}
