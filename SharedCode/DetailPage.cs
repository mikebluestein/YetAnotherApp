using System;
using Xamarin.Forms;

namespace YetAnotherAppShared
{
    public class DetailPage : ContentPage
    {
        public DetailPage (string imagesource)
        {
            Padding = new Thickness (10, 80, 10, 10);

            BackgroundColor = Color.Black;

            var image = new Image { Aspect = Aspect.AspectFit };
            image.Source = imagesource;

            var a = new Label {
                Text = "Xamarin.Forms Page",
                TextColor = Color.White,
                FontSize = 20,
                XAlign = TextAlignment.Center
            };

            var b = new Label {
                Text = imagesource,
                TextColor = Color.White,
                FontSize = 20,
                XAlign = TextAlignment.Center
            };

            Content = new StackLayout {
                Spacing = 10,
                Children = {a, image, b }
            };
        }
    }
}