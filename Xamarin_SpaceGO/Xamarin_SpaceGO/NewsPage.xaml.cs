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
    public partial class NewsPage : ContentPage
    {
        int bkm = 0;
        int i = 0;

        public NewsPage()
        {
            InitializeComponent();
            userID.Text = "userandrei";
            bookmarkCount.Text = $"Bookmarks count: {bkm}";
            image.Source = ImageSource.FromResource(imagesArr[i]);
        }

        string[] imagesArr = 
        {
            "Xamarin_SpaceGO.Images.blackholemobile.jpg",
            "Xamarin_SpaceGO.Images.earthmobile.png",
            "Xamarin_SpaceGO.Images.spacecloudmobile.jpg"
        };
        

        private void BtnBookmarkClicked(object sender, EventArgs e)
        {
            bkm++;
            bookmarkCount.Text = $"Bookmarks count: {bkm}";
        }

        private void BtnBackClicked(object sender, EventArgs e)
        {
            if (i == 0)
                i = 2;
            else
                i -= 1;

            image.Source = ImageSource.FromResource(imagesArr[i]);
        }

        private void BtnNextClicked(object sender, EventArgs e)
        {
            if (i == 2)
                i = 0;
            else
                i += 1;

            image.Source = ImageSource.FromResource(imagesArr[i]);
        }
    }
}