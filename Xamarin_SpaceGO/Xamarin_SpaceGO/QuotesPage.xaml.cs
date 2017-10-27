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
    public partial class QuotesPage : ContentPage
    {
        int i = 0;
        string[] QuotesArr = new string[]
        {
            "Kiska ea teba liubliu",
            "Tilno",
            "Oceni tilino"
        };

        public QuotesPage()
        {
            InitializeComponent();
            currentQuote.Text = QuotesArr[i];
        }

        private void BtnNextQuote_Clicked(object sender, EventArgs e)
        {
            i++;
            if (i >= 3)
                i = 0;
            currentQuote.Text = QuotesArr[i];
        }
    }
}