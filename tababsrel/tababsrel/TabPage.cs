using System;

using Xamarin.Forms;

namespace tababsrel
{
    // it is here that we say we want the page to be a tabbed page
    // the reason is simple. A tabbed page (the one with the tabs set up in it), can be considered a Parent page
    // with each tab a Page in their own right. It's up to you what you do with those pages.
    // the important thing is to say we're inheritting TabbedPage rather than ContentPage - the tabbed page has no content
    public class TabPage : TabbedPage
    {
        readonly Page AbsolutePage, RelativePage;

        public TabPage()
        {
            Children.Add(new AbsolutePage() { Title = "Absolute layout" });
            Children.Add(new RelativePage() { Title = "Relative layout" });

            // Current page is the tabbedpage property denoting which of the child pages you're on
            CurrentPage = Children[0];
        }

        public void SwitchToTab1()
        {
            CurrentPage = AbsolutePage;
        }

        public void SwitchToTab2()
        {
            CurrentPage = RelativePage;
        }
    }
}


