using System;

using Xamarin.Forms;

namespace tababsrel
{
    public class AbsolutePage : ContentPage
    {
        readonly Label text1, text2;
        bool isCurrentPage;

        public AbsolutePage()
        {
            // as with any layout, we have to create it first.
            // we'lll also give it a bit of colour

            var absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.Green.WithLuminosity(0.75),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // we need to now add something to the layout. In this case, we're adding two labels which we'll then perform
            // some simple animation on

            text1 = new Label
            { 
                Text = "Absolute Layout",
                TextColor = Color.Black
            };

            // to actually do something with the layer. we need to add what we have created to the layer
            // this is done by adding to the Children AbsoluteLayer.IAbsoluteList<View> in the same
            // way as we do to the stack
            absoluteLayout.Children.Add(text1);
            AbsoluteLayout.SetLayoutFlags(text1, AbsoluteLayoutFlags.PositionProportional);

            text2 = new Label
            { 
                Text = "Absolute Layout",
                TextColor = Color.Blue
            };
            absoluteLayout.Children.Add(text2);
            AbsoluteLayout.SetLayoutFlags(text2, AbsoluteLayoutFlags.PositionProportional);

            Content = new StackLayout
            {
                Children =
                {
                    absoluteLayout
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isCurrentPage = true;
            DateTime beginTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1.0 / 30), () =>
                {
                    var seconds = (DateTime.Now - beginTime).TotalSeconds;
                    var offset = 1 - Math.Abs((seconds % 2) - 1);

                    // Rectangle can be considered the same as RectF when using System.Drawing(x, y, width, height)
                    // we are moving the text in and down when the timer has elapsed
                    AbsoluteLayout.SetLayoutBounds(text1, new Rectangle(offset, offset, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                    AbsoluteLayout.SetLayoutBounds(text2, new Rectangle(1 - offset, offset, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                    return isCurrentPage;
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isCurrentPage = false;
        }
    }
}


