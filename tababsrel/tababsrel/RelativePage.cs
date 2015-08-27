
using Xamarin.Forms;

namespace tababsrel
{
    public class RelativePage : ContentPage
    {
        public static double GetFontNamedSize<T>(NamedSize size, T uitype)
        {
            return Device.GetNamedSize(size, typeof(T));
        }

        public RelativePage()
        {
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            // Create the RelativeLayout
            var relativeLayout = new RelativeLayout();

            // A Label whose upper-left is centered vertically.
            var referenceLabel = new Label
            {
                Text = "Not visible",
                Opacity = 0,
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(referenceLabel, Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => parent.Height / 2));

            // A Label centered vertically.
            var centerLabel = new Label
            {
                Text = "Centre",
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(centerLabel, Constraint.Constant(0),
                Constraint.RelativeToView(referenceLabel, (parent, sibling) => sibling.Y - sibling.Height / 2));

            // A Label above the centered Label.
            var aboveLabel = new Label
            {
                Text = "Above",
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(aboveLabel,
                Constraint.RelativeToView(centerLabel, (parent, sibling) => sibling.X + sibling.Width),
                Constraint.RelativeToView(centerLabel, (parent, sibling) => sibling.Y - sibling.Height));

            // A Label below the centered Label.
            var belowLabel = new Label
            {
                Text = "Below",
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(belowLabel,
                Constraint.RelativeToView(centerLabel, (parent, sibling) => sibling.X + sibling.Width),
                Constraint.RelativeToView(centerLabel, (parent, sibling) => sibling.Y + sibling.Height));

            // Finish with another on top...
            var furtherAboveLabel = new Label
            {
                Text = "Further Above",
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(furtherAboveLabel,
                Constraint.RelativeToView(aboveLabel, (parent, sibling) => sibling.X + sibling.Width),
                Constraint.RelativeToView(aboveLabel, (parent, sibling) => sibling.Y - sibling.Height));

            // ...and another on the bottom.
            var furtherBelowLabel = new Label
            {
                Text = "Further Below",
                FontSize = GetFontNamedSize(NamedSize.Large, typeof(Label))
            };
            relativeLayout.Children.Add(furtherBelowLabel,
                Constraint.RelativeToView(belowLabel, (parent, sibling) => sibling.X + sibling.Width),
                Constraint.RelativeToView(belowLabel, (parent, sibling) => sibling.Y + sibling.Height));

            // Four BoxView's
            relativeLayout.Children.Add(
                new BoxView { Color = Color.Red },
                Constraint.Constant(0),
                Constraint.Constant(0));

            relativeLayout.Children.Add(
                new BoxView { Color = Color.Green },
                Constraint.RelativeToParent((parent) => parent.Width - 40), Constraint.Constant(0));

            relativeLayout.Children.Add(
                new BoxView { Color = Color.Blue },
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => parent.Height - 40));

            relativeLayout.Children.Add(
                new BoxView { Color = Color.Yellow },
                Constraint.RelativeToParent((parent) => parent.Width - 40),
                Constraint.RelativeToParent((parent) => parent.Height - 40));

            var grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                }
            };
            grid.Children.Add(relativeLayout, 0, 1);

            Content = grid;
        }
    }
}


