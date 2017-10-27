using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_SpaceGO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuyCreditsPage : ContentPage
    {
        public BuyCreditsPage()
        {
            InitializeComponent();
            currentCredits.Text = $"${_credits:F2}";
            addCredits.Text = $"Add ${addCreditsValue} credits";
        }

        double _credits = 0;
        double addCreditsValue = 7.99;

        private void AddCredits_Clicked(object sender, EventArgs e)
        {
            _credits += addCreditsValue;
            currentCredits.Text = $"${_credits:F2}";
        }
    }
}